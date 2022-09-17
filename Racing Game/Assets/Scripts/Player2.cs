using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Transform centerOfMass;

    public WheelCollider wheelColliderLeftFront;
    public WheelCollider wheelColliderRightFront;
    public WheelCollider wheelColliderLeftBack;
    public WheelCollider wheelColliderRightBack;

    public Transform wheelLeftFront;
    public Transform wheelRightFront;
    public Transform wheelLeftBack;
    public Transform wheelRightBack;

    public float motorTorque = 100f;
    public float maxSteer = 20f;
    private Rigidbody _rigidbody;

    public GameObject p2laps;
    public GameObject go;

    float timer;

    public int maxfuel2 = 100;
    public p2fuelbar p2Fuelbar;
    public int currentgas2;

    public float speed;

    public p2lowfuel p2LowFuel;

    public float speedometer;
    public int speedRounded;

    public p2speedometer p2Speedometer;

    public bool fuelmap;

    AudioSource audioSource;


    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;

        p2Fuelbar.SetMaxFuel2(maxfuel2);

        currentgas2 = maxfuel2;

        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (go.tag == "go")
        {
            wheelColliderLeftBack.motorTorque = Input.GetAxis("Vertical2") * motorTorque;
            wheelColliderRightBack.motorTorque = Input.GetAxis("Vertical2") * motorTorque;
            wheelColliderLeftFront.motorTorque = Input.GetAxis("Vertical2") * motorTorque / 2;
            wheelColliderRightFront.motorTorque = Input.GetAxis("Vertical2") * motorTorque / 2;
            wheelColliderLeftFront.steerAngle = Input.GetAxis("Horizontal2") * maxSteer;
            wheelColliderRightFront.steerAngle = Input.GetAxis("Horizontal2") * maxSteer;
        }
    }

    private void Update()
    {
        speedometer = _rigidbody.velocity.magnitude * 3;
        speedRounded = (int)speedometer;

        p2Speedometer.SetSpeed2(speedRounded);

        audioSource.pitch = 3 * _rigidbody.velocity.magnitude / 30;

        var pos = Vector3.zero;
        var rot = Quaternion.identity;

        wheelColliderLeftFront.GetWorldPose(out pos, out rot);
        wheelLeftFront.position = pos;
        wheelLeftFront.rotation = rot * Quaternion.Euler(0, 180, 0);

        wheelColliderRightFront.GetWorldPose(out pos, out rot);
        wheelRightFront.position = pos;
        wheelRightFront.rotation = rot;

        wheelColliderLeftBack.GetWorldPose(out pos, out rot);
        wheelLeftBack.position = pos;
        wheelLeftBack.rotation = rot * Quaternion.Euler(0, 180, 0);

        wheelColliderRightBack.GetWorldPose(out pos, out rot);
        wheelRightBack.position = pos ;
        wheelRightBack.rotation = rot;

        if (p2laps.tag == "finished")
        {
            Destroy(this);
        }

        timer += Time.deltaTime;
        if (timer >= speed && go.tag == "go" && fuelmap == true)
        {
            currentgas2--;
            timer = 0f;

        }

        p2Fuelbar.SetFuel2(currentgas2);
        p2LowFuel.SetFuel(currentgas2);

        if (currentgas2 <= 0)
        {
            _rigidbody.velocity = Vector3.zero;
            Destroy(this);
            _rigidbody.velocity = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gas")
        {
            if (currentgas2 < 100)
            {
                currentgas2 = currentgas2 + 10;
            }
        }
    }
}
