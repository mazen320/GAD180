using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUIP1;
    public GameObject completeLevelUIP2;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player1")
        {
        completeLevelUIP1.SetActive(true);
        completeLevelUIP2.SetActive(false);
        }

        if (col.tag == "Player2")
        {
        completeLevelUIP2.SetActive(true);
        completeLevelUIP1.SetActive(false);
        }
    }

}

