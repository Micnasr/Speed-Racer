using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Player : MonoBehaviour
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

    public GameObject p1laps;
    public GameObject go;

    public float speed;

    float timer;

    public int maxfuel = 100;
    public p1fuelbar p1Fuelbar;
    public int currentgas;

    public p1lowfuel p1LowFuel;

    public float speedometer;
    public int speedRounded;

    public p1speedometer p1Speedometer;

    public bool fuelmap;

    AudioSource audioSource;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;

        p1Fuelbar.SetMaxFuel(maxfuel);

        currentgas = maxfuel;

        audioSource = GetComponent<AudioSource>();

    }

    private void FixedUpdate()
    {
        if (go.tag == "go"){
            wheelColliderLeftBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;
            wheelColliderRightBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;
            wheelColliderLeftFront.motorTorque = Input.GetAxis("Vertical") * motorTorque / 2;
            wheelColliderRightFront.motorTorque = Input.GetAxis("Vertical") * motorTorque / 2;
            wheelColliderLeftFront.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
            wheelColliderRightFront.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        }

    }

    private void Update()
    {
        speedometer = _rigidbody.velocity.magnitude * 3;
        speedRounded = (int) speedometer;
        
        p1Speedometer.SetSpeed(speedRounded);

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
        wheelLeftBack.rotation = rot * Quaternion.Euler(0,180,0);

        wheelColliderRightBack.GetWorldPose(out pos, out rot);
        wheelRightBack.position = pos;
        wheelRightBack.rotation = rot;
        

        if (p1laps.tag == "finished")
        {
            Destroy(this);
        }

        timer += Time.deltaTime;
        if (timer >= speed && go.tag == "go" && fuelmap == true)
        {
            currentgas--;
            timer = 0f;

        }

        p1Fuelbar.SetFuel(currentgas);
        p1LowFuel.SetFuel(currentgas);

        if (currentgas <= 0)
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
            if (currentgas < 100)
            {
                currentgas = currentgas + 10;
            }
        }
    }

    
}
