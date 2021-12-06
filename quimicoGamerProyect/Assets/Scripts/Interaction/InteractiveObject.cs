using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public interactiveObjType typeObj;

    //acction when on radio trigger area 
    public virtual void PlayerInRange()
    {
        Debug.Log("IN Ranggeeeeeeee"); 
        Debug.Log("El jugador entro " + this.name);
        //in here we can call other scripts,
        //create a swtich to programe the action
    }

    public virtual void PlayerOutOfRange()
    {
        //Debug.Log("El jugador salio " + this.name);
    }
}

public enum interactiveObjType
{
    clock, 
    aidKit, 
}
