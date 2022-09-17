using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2lowfuel : MonoBehaviour
{
    public GameObject player;
    public Text message;

    public GameObject p1laps;
    public GameObject p2laps;

    int gas;

    public void SetFuel(int fuel)
    {

        gas = fuel;

    }

    void Update()
    {
        
        if (gas < 30 && gas > 0 && p1laps.tag != "finished" && p2laps.tag != "finished")
        {

            message.text = "LOW FUEL";

        }
        else if (gas > 29)
        {
            message.text = "";
        }
        else if (gas == 0 && p1laps.tag != "finished" && p2laps.tag != "finished")
        {
            message.text = "OUT OF FUEL";
        } else
        {
            message.text = "";
        }
    }

}
