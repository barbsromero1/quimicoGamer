using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneManagment : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene"); 
    }
    public void QuitGame()
    {
        Debug.Log("QuitGame"); 
        Application.Quit(); 
    }
}
