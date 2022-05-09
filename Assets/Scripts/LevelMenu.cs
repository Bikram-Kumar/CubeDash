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

        if (highestLevelReached == 0)
        {
            highestLevelReached = 1;
        } else if (highestLevelReached == 11)
        {
            highestLevelReached = 10;
        }

        for (int i = 1; i <= highestLevelReached; i++)
        {
            levelOptions.Add("Level " + i);
        }

        levelSelector.ClearOptions();
        levelSelector.AddOptions(levelOptions);
        
    }


}
