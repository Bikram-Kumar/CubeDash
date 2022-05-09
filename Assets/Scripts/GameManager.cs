using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public int CoinCount;
    Text CoinCountText;

    public GameObject completeLevelUI;
    GameObject PauseMenu;
  
    GameObject ResumeMenu;


    void Start()
    {
        CoinCountText = GameObject.Find("Canvas/CoinDisplayParent/CoinCount").GetComponent<Text>();
        PauseMenu = GameObject.Find("Canvas/PauseMenu");
        ResumeMenu = GameObject.Find("Canvas/ResumeMenu");

        CoinCountText.text = CoinCount.ToString();
        ResumeMenu.SetActive(false);

    }


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }   

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }


    public void IncreaseCoinCount()
    {
        CoinCount++;
        CoinCountText.text = CoinCount.ToString();
    }




    public void PauseGame()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(false);
        ResumeMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        ResumeMenu.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
