using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint1 : MonoBehaviour
{
   

    public GameObject p1;
    public GameObject p2;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            
            p1.tag = "touched";

        }

        if (collision.gameObject.tag == "player2")
        {
           
            p2.tag = "touched";
        }
    }
}
