using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapselections : MonoBehaviour
{
    public void fuelmap1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("ClickNoise");
    }

    public void map1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        FindObjectOfType<AudioManager>().Play("ClickNoise");
    }

    public void map2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        FindObjectOfType<AudioManager>().Play("ClickNoise");
    }


}
