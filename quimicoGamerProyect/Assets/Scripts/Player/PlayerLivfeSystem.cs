using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLivfeSystem : MonoBehaviour
{
    public int lives;
    public int add;
    public int substract; 

    //make initialize lives 
    void Start()
    {
        lives = 100; 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            AddLife(10); 
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            RemoveLife(20);
        }
    }

    //when they are added 
    public void AddLife(int add)
    {
        lives += add;
        Debug.Log("AddLife " + lives);
        //UIManager.Instance.UpdateLivesUI(_lives);
    }

    //when he has to loose 
    public void RemoveLife(int substract)
    {
        lives -= substract;
        Debug.Log("RemovalLife " + lives);
        //UIManager.Instance.UpdateLivesUI(_lives);

        if (lives == 0)
        {
            Debug.Log("Game Over"); 
        }
    }
}
