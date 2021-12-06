using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOver : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f ;

    public GameObject gameOverMenuUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameOverMenuUI.SetActive(true);
            gameHasEnded = true;
            Time.timeScale = 0f;
            Debug.Log("GameHasEnded");
            Invoke("Restart", restartDelay);
        }
        else
        {
            gameOverMenuUI.SetActive(false);
        }
    }

    public void Restart()
    {
        Invoke("ReLoadScene", restartDelay);
        Debug.Log("Restartttttt");
        Time.timeScale = 1f;
    }

    public void ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
