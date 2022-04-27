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


    void Start()
    {
        CoinCountText = GameObject.Find("Canvas/CoinDisplayParent/CoinCount").GetComponent<Text>();
        CoinCountText.text = CoinCount.ToString();
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

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
