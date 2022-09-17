using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1start : MonoBehaviour
{

    public Text startscreen;
    [SerializeField] float timer;

    public GameObject go;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("321GO");
    }

    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer >= 1 && timer < 2)
        {
            startscreen.text = "3";
            

        } else if (timer >= 2 && timer < 3)
        {
            startscreen.text = "2";
        } else if (timer >= 3 && timer < 4)
        {
            startscreen.text = "1";
        } else if (timer >= 4 && timer < 5)
        {
            startscreen.text = "GO!";
            go.tag = "go";
        } else if (timer > 5)
        {
            startscreen.text = "";
            Destroy(this);
        }
    }
}
