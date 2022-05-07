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
    public GameObject ResumeMenu;


    void Start()
    {
        CoinCountText = GameObject.Find("Canvas/CoinDisplayParent/CoinCount").GetComponent<Text>();
        CoinCountText.text = CoinCount.ToString();
        PauseMenu = GameObject.Find("Canvas/PauseMenu");
        Debug.Log(PauseMenu);
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


    public void IncreaseCoinCount()
    {
        CoinCount++;
        CoinCountText.text = CoinCount.ToString();
    }



    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        // PauseMenu.SetActive(false);
        // ResumeMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        // PauseMenu.SetActive(true);
        // ResumeMenu.SetActive(false);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
