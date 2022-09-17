using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint5 : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;

    public GameObject c4p1;
    public GameObject c4p2;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            if (c4p1.tag == "touched")
            {
                p1.tag = "touched";

            }

        }

        if (collision.gameObject.tag == "player2")
        {
            if (c4p2.tag == "touched")
            {
                p2.tag = "touched";

            }
        }
    }
}
