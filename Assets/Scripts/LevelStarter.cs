using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStarter : MonoBehaviour
{
   public int levelSelected = 1;
   

   public void SetLevelSelected(int num)
   {
       levelSelected = num + 1;
   }

   public void StartLevel()
   {
       SceneManager.LoadScene(levelSelected);
       Debug.Log(levelSelected);
   }
}
