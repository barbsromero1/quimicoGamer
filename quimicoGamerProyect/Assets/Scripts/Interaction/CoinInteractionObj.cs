using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInteractionObj : InteractiveObject
{
    public override void PlayerInRange()
    {
        this.gameObject.SetActive(false);
        FindObjectOfType<GameOver>().EndGame();
        Debug.Log("Game Over");
    }
}
