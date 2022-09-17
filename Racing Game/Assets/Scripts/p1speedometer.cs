using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1speedometer : MonoBehaviour
{
    public Text speedometers;
    float speed;

    public void SetSpeed(int speedometer)
    {

        speed = speedometer;

    }
    void Update()
    {
        speedometers.text = "Speed: " + speed;
    }
}
