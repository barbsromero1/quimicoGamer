using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public interactiveObjType typeObj;

    //acction when on radio trigger area 
    public virtual void PlayerInRange()
    {
        this.gameObject.SetActive(false);
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
