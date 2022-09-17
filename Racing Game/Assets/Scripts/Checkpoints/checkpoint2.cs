using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint2 : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;

    public GameObject c1p1;
    public GameObject c1p2;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            if (c1p1.tag == "touched")
            {
                p1.tag = "touched";

            }

        }

        if (collision.gameObject.tag == "player2")
        {
            if (c1p2.tag == "touched")
            {
                p2.tag = "touched";

            }
        }
    }
}
