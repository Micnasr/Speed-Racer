using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2speedometer : MonoBehaviour
{
    public Text speedometers;
    float speed;

    public void SetSpeed2(int speedometer2)
    {

        speed = speedometer2;

    }
    void Update()
    {
        speedometers.text = "Speed: " + speed;
    }
}
