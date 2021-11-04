using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public GameObject zombiePrefab;
    public Queue<GameObject> zombiePool = new Queue<GameObject>();
    public int poolStartSize = 5; 

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject zombie = Instantiate(zombiePrefab);
            zombiePool.Enqueue(zombie);
            zombie.SetActive(false); 
        }
    }

    public GameObject GetZoombie()
    {
        if (zombiePool.Count > 0)
        {
            GameObject zombie = zombiePool.Dequeue();
            zombie.SetActive(true);
            return zombie; 
        }
        else
        {
            GameObject zombie = Instantiate(zombiePrefab);
            return zombie; 
        }
    }

    public void ReturnZoombie(GameObject zombie)
    {
        zombiePool.Enqueue(zombie);
        zombie.SetActive(false); 
    }
}
