using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInteractiveObj : InteractiveObject
{
    public Timer gameTime;

    public override void PlayerInRange()
    {
        gameTime.timeValue = 120;
        this.gameObject.SetActive(false);
    }
}
