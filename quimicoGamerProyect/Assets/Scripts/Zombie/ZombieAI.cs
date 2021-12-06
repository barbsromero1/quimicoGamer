using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public NavMeshAgent agent;
    private Transform playerPoint; 


    // Start is called before the first frame update
    void Start()
    {
        playerPoint = PlayerManager.instance.player.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        //float distance = Vector3.Distance(playerPoint.position, transform.position);
        agent.SetDestination(playerPoint.position);
    }
}
