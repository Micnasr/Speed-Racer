using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinmain : MonoBehaviour
{
    public float rotSpeed;
  
    

    
    void Update()
    {
        transform.Rotate(0, rotSpeed, 0);
    }
}
