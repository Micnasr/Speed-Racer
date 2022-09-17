using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int p1Lap = 0;
    public int p2Lap = 0;

    public GameObject c1p1;
    public GameObject c1p2;

    public GameObject c2p1;
    public GameObject c2p2;

    public GameObject c3p1;
    public GameObject c3p2;

    public GameObject c4p1;
    public GameObject c4p2;

    public GameObject c5p1;
    public GameObject c5p2;

    public GameObject p1Laps;
    public GameObject p2Laps;

    public GameObject ailap;

    int ailaps = 0;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            if (c5p1.tag == "touched")
            {
                p1Lap++;

                c1p1.tag = "nottouched";
                c2p1.tag = "nottouched";
                c3p1.tag = "nottouched";
                c4p1.tag = "nottouched";
                c5p1.tag = "nottouched";
            }

        }

        if (collision.gameObject.tag == "player2")
        {

            if (c5p2.tag == "touched")
            {
                p2Lap++;

                c1p2.tag = "nottouched";
                c2p2.tag = "nottouched";
                c3p2.tag = "nottouched";
                c4p2.tag = "nottouched";
                c5p2.tag = "nottouched";

            }
        }

        if (collision.tag == "ai")
        {
            ailaps++;
        }
    }

    void Update()
    {
        if (p1Lap == 0)
        {
            p1Laps.tag = "0";
        }
        else if (p1Lap == 1)
        {
            p1Laps.tag = "1";
        }
        else if (p1Lap == 2)
        {
            p1Laps.tag = "2";
        }
        else if (p1Lap == 3)
        {
            p1Laps.tag = "3";
        }
        else if (p1Lap == 4)
        {
            p1Laps.tag = "finished";
        }

        if (p2Lap == 0)
        {
            p2Laps.tag = "0";
        }
        else if (p2Lap == 1)
        {
            p2Laps.tag = "1";
        }
        else if (p2Lap == 2)
        {
            p2Laps.tag = "2";
        }
        else if (p2Lap == 3)
        {
            p2Laps.tag = "3";
        }
        else if (p2Lap == 4)
        {
            p2Laps.tag = "finished";
        }

        if (ailaps == 0)
        {
            ailap.tag = "0";
        }
        else if (ailaps == 1)
        {
            ailap.tag = "0";
        }
        else if (ailaps == 2)
        {
            ailap.tag = "1";
        }
        else if (ailaps == 3)
        {
            ailap.tag = "2";
        }
        else if (ailaps == 4)
        {
            ailap.tag = "3";
        }
        else if (ailaps == 5)
        {
            ailap.tag = "finished";
        }
    }
}
