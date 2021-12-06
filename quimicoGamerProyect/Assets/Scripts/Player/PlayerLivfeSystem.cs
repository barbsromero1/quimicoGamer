using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLivfeSystem : MonoBehaviour
{
    public int lives;
    public int add;
    public int substract;
    public Animator playerAnimator;
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
        //UIManager.Instance.UpdateLivesUI(_lives);
    }

    //when he has to loose 
    public void RemoveLife(int substract)
    {
        if (lives > 0)
        {
            lives -= substract;
            Debug.Log("menos vida");
        }
       else
        {
            playerAnimator.SetBool("die", true);
            new WaitForSeconds(2);
            //FindObjectOfType<GameOver>().EndGame();
            Debug.Log("Game Over");
            return;

        }
    }
}
