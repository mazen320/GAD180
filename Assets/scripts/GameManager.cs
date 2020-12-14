using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject completeLevelUIP1;
    public GameObject completeLevelUIP2;
    
    public void CompleteLevel()
    {
        completeLevelUIP1.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
      
        }
    }

   

}
