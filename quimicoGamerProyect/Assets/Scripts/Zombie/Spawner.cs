using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn = 5f;
    private float timeSinceSpawn;
    public ObjectPooler objectPooler;

    public float lookRadius = 5f;
    private Transform playerPoint;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = FindObjectOfType<ObjectPooler>();
        playerPoint = PlayerManager.instance.player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        float distance = Vector3.Distance(playerPoint.position, transform.position);
        if (distance <= lookRadius)
        {
            if (timeSinceSpawn >= timeToSpawn)
            {
                GameObject newZombie = objectPooler.GetZoombie();
                newZombie.transform.position = this.transform.position;
                timeSinceSpawn = 0f;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
