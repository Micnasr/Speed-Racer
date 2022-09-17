using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1laps : MonoBehaviour
{

    public Text scoreText;
    
    public GameObject LapsP1;

    void Start()
    {
        
    }



    void Update()
    {
        if (LapsP1.tag == "0") {
            scoreText.text = "0";
        } else if (LapsP1.tag == "1")
        {
            scoreText.text = "1";
        } else if (LapsP1.tag == "2")
        {
            scoreText.text = "2";
        } else if (LapsP1.tag == "3")
        {
            scoreText.text = "3";
        }

    }
}
