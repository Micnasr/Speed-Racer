using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosivebarrel : MonoBehaviour
{
    public GameObject explosiveParticle;

    public float force;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player1" || collision.gameObject.tag == "player2")
        {
            Instantiate(explosiveParticle, transform.position, Quaternion.identity);

            Collider[] colliders = Physics.OverlapSphere(transform.position, 100);

            foreach (Collider nearbyObject in colliders)
            {
                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(force, transform.position, 100);
                }
            }

           
            Destroy(gameObject);
        }
       
    }

}
