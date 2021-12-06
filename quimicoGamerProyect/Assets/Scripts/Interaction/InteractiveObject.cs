using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    //acction when on radio trigger area 
    public virtual void PlayerInRange()
    {
        
    }

    public virtual void PlayerOutOfRange()
    {
        //Debug.Log("El jugador salio " + this.name);
    }
}
