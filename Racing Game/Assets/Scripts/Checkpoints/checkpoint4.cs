using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint4 : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;

    public GameObject c3p1;
    public GameObject c3p2;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            if (c3p1.tag == "touched")
            {
                p1.tag = "touched";

            }

        }

        if (collision.gameObject.tag == "player2")
        {
            if (c3p2.tag == "touched")
            {
                p2.tag = "touched";

            }
        }
    }
}
