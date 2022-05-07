using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoodLuckMessage : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("LevelNum").GetComponent<Text>().text = SceneManager.GetActiveScene().buildIndex.ToString();
    }


    public void HideMessage()
    {
        gameObject.SetActive(false);
    }

}
