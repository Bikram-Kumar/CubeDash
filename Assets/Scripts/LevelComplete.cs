using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
void Start()
{
    GameObject.Find("LevelNum").GetComponent<Text>().text = SceneManager.GetActiveScene().buildIndex.ToString();
}
   
public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

}
