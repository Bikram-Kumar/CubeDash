using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    
    Dropdown levelSelector;
    List<string> levelOptions = new List<string>();

    void Start()
    {
        levelSelector = GetComponent<Dropdown>();
        int highestLevelReached = PlayerPrefs.GetInt("PlayerLevel");
        highestLevelReached = highestLevelReached == 0 ? 1 : highestLevelReached;

        for (int i = 1; i <= highestLevelReached; i++)
        {
            levelOptions.Add("Level " + i);
        }
        Debug.Log(levelOptions);
        Debug.Log(highestLevelReached);

        levelSelector.ClearOptions();
        levelSelector.AddOptions(levelOptions);
        
    }


}
