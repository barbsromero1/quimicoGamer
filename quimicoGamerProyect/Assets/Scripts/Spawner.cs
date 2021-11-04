using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn = 5f;
    private float timeSinceSpawn;
    public ObjectPooler objectPooler; 

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = FindObjectOfType<ObjectPooler>(); 
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn >= timeToSpawn)
        {
            GameObject newZombie = objectPooler.GetZoombie();
            newZombie.transform.position = this.transform.position;
            timeSinceSpawn = 0f; 
        }
    }
}
