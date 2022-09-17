using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Laps : MonoBehaviour
{

    public Text scoreText;

    public GameObject LapsP2;

    void Start()
    {

    }



    void Update()
    {
        if (LapsP2.tag == "0")
        {
            scoreText.text = "0";
        }
        else if (LapsP2.tag == "1")
        {
            scoreText.text = "1";
        }
        else if (LapsP2.tag == "2")
        {
            scoreText.text = "2";
        }
        else if (LapsP2.tag == "3")
        {
            scoreText.text = "3";
        }

    }
}
