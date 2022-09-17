using UnityEngine;

public class AI : MonoBehaviour
{

    public GameObject targ1;
    public GameObject targ2;
    public GameObject targ3;
    public GameObject targ4;
    public GameObject targ5;
    public GameObject targ6;
    public GameObject targ7;
    public GameObject targ8;
    public GameObject targ9;
    public GameObject targ10;
    public GameObject targ11;
    public GameObject targ12;

    public Transform targ1transform;
    public Transform targ2transform;
    public Transform targ3transform;
    public Transform targ4transform;
    public Transform targ5transform;
    public Transform targ6transform;
    public Transform targ7transform;
    public Transform targ8transform;
    public Transform targ9transform;
    public Transform targ10transform;
    public Transform targ11transform;
    public Transform targ12transform;

    public GameObject go;

    float[] speed = new float[12];

    float acceleration = 0.1f;


    void Start()
    {
        for(int i = 0; i < 12; i++) 
{
            speed[i] = Random.Range(0.16f, 0.19f);
        }
       
        
    }

    
    void Update()
    {

        

        if (targ1.tag == "nottouched" && go.tag == "go")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ1.transform.position, acceleration);
            transform.LookAt(targ1transform);
        }
        

        if (targ2.tag == "nottouched" && targ1.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ2.transform.position, speed[0]);
            transform.LookAt(targ2transform);
        }

        if (targ3.tag == "nottouched" && targ2.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ3.transform.position, speed[1]);
            transform.LookAt(targ3transform);
        }

        if (targ4.tag == "nottouched" && targ3.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ4.transform.position, speed[2]);
            transform.LookAt(targ4transform);
        }

        if (targ5.tag == "nottouched" && targ4.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ5.transform.position, speed[3]);
            transform.LookAt(targ5transform);
        }

        if (targ6.tag == "nottouched" && targ5.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ6.transform.position, speed[4]);
            transform.LookAt(targ6transform);
        }

        if (targ7.tag == "nottouched" && targ6.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ7.transform.position, speed[5]);
            transform.LookAt(targ7transform);
        }

        if (targ8.tag == "nottouched" && targ7.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ8.transform.position, speed[6]);
            transform.LookAt(targ8transform);
        }

        if (targ8.tag == "nottouched" && targ7.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ8.transform.position, speed[7]);
            transform.LookAt(targ8transform);
        }


        if (targ9.tag == "nottouched" && targ8.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ9.transform.position, speed[8]);
            transform.LookAt(targ9transform);
        }

        if (targ10.tag == "nottouched" && targ9.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ10.transform.position, speed[9]);
            transform.LookAt(targ10transform);
        }

        if (targ11.tag == "nottouched" && targ10.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ11.transform.position, speed[10]);
            transform.LookAt(targ11transform);
            
        }


        if (targ12.tag == "nottouched" && targ11.tag == "touched")
        {
            transform.position = Vector3.MoveTowards(transform.position, targ12.transform.position, speed[11]);
            transform.LookAt(targ12transform);
            Reset();
            
        }



    }

    void Reset()
    {
        targ1.tag = "nottouched";
        targ2.tag = "nottouched";
        targ3.tag = "nottouched";
        targ4.tag = "nottouched";
        targ5.tag = "nottouched";
        targ6.tag = "nottouched";
        targ7.tag = "nottouched";
        targ8.tag = "nottouched";
        targ9.tag = "nottouched";
        targ10.tag = "nottouched";
        targ11.tag = "nottouched";
        targ12.tag = "nottouched";
        

    }
}
