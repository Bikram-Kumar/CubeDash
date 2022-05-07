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
    int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    SceneManager.LoadScene(nextLevel);
    PlayerPrefs.SetInt("PlayerLevel", nextLevel);
    PlayerPrefs.Save();
}

}
