using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congrats : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

}
