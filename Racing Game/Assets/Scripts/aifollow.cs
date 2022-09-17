using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aifollow : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ai")
        {
            gameObject.tag = "touched";
        }
    }
}
