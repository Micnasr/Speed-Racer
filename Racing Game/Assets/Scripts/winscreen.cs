using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winscreen : MonoBehaviour
{
    public GameObject p1laps;
    public GameObject p2laps;
    public GameObject ailap;

    public Text winText;
    void Update()
    {
        if (p1laps.tag == "finished" && p2laps.tag != "finished" && ailap.tag !="finished")
        {
            winText.text = "PLAYER 1 WON!";
        }

        if (p2laps.tag == "finished" && p1laps.tag != "finished" && ailap.tag != "finished")
        {
            winText.text = "PLAYER 2 WON!";
        }

        if (ailap.tag == "finished" && p1laps.tag != "finished" && p2laps.tag != "finished")
        {
            winText.text = "AI WON!";
        }
    }
}
