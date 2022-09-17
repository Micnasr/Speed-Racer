using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        FindObjectOfType<AudioManager>().Play("ClickNoise");
    }

    public void ExitGame()
    {
        Application.Quit();

        FindObjectOfType<AudioManager>().Play("ClickNoise");
    }
}
