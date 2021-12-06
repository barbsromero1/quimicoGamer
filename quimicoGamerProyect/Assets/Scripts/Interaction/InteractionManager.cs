using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public InteractiveObject interactiveObject;
    private bool insideInteractiveObj;

    //detects when the object is on range 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("IsTriggered "); 
        interactiveObject = other.GetComponent<InteractiveObject>();
        if (interactiveObject != null)
        {
            interactiveObject.PlayerInRange();
        }
    }

    //detects when player has gone out of range 
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ExitTrigger ");
        interactiveObject.PlayerOutOfRange();
        interactiveObject = null;
    }

    // Update is called once per frame
    void Update()
    {
        //makes sure the player is in range to call function 
        //if (interactiveObject != null)
        //{
        //    if (Input.GetKeyDown(KeyCode.H))
        //    {
        //        interactiveObject.PlayerInRange();
        //    }
        //}

    }
}
