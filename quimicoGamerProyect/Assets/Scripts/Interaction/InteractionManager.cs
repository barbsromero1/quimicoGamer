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
            Debug.Log("interactive NOT FOUND"); 
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

}
