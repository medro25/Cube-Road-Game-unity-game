using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartdelay=2f;
    public GameObject CompleteLevelUI ;
    public GameObject GameOverUI;
     bool levelCompleted = false;
     public void LevelCompleted()
    {
        if (!levelCompleted)  // Check if the level is already completed
        {
            levelCompleted = true;  
            CompleteLevelUI.SetActive(true);
        }
    }

    public void Endgame()
    {
        if(gameHasEnded==false)
        {
       
            gameHasEnded = true;
            Debug.Log("Game Over");
            GameOverUI.SetActive(true);
             //Invoke("restart",restartdelay);
        }
    }

    public void restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
