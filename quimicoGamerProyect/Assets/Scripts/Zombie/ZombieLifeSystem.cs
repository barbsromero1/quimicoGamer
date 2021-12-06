using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLifeSystem : MonoBehaviour
{
    public int lives;
    public int add;
    public int substract;
    public ObjectPooler objectPooler;

    public Animator animatorPersonaje;

    //make initialize lives 
    void Start()
    {
        lives = 100;
        objectPooler = FindObjectOfType<ObjectPooler>();
    }

    private void Update()
    {
    }
    
    //when he has to loose 
    public void RemoveLife(int substract)
    {
        lives -= substract;
        //UIManager.Instance.UpdateLivesUI(_lives);
        if (lives <= 0)
        {
            //animatorPersonaje
        }
    }

}
