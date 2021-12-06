using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionInteractiveObj : InteractiveObject
{
    public PlayerLivfeSystem playerLifeSystem;

    public override void PlayerInRange()
    {
        playerLifeSystem.lives = 200;
        this.gameObject.SetActive(false); 
        Debug.Log("ENTRO Segundo Tipo de Acción  " + this.name);
    }
}
