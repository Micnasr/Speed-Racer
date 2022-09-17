using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasnozzle : MonoBehaviour
{
    public float rotSpeed;
    bool dead = false;

    [SerializeField] float timer;

    int respawntimer = 5;

    Vector3 currentPos;

    void Update()
    {

        transform.Rotate(0, rotSpeed, 0);

        if (dead == true)
        {
            
            timer += Time.deltaTime;
            if (timer >= respawntimer)
            {
                dead = false;
                transform.position = currentPos;
                timer = 0f;

            }
        }
    }

    

    void OnTriggerEnter(Collider other)
    {
        dead = true;
        currentPos = transform.position;
        transform.Translate(new Vector3(transform.position.x, transform.position.y + 500, transform.position.z));


    }
}
