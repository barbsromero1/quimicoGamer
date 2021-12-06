using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 300;
    public Text timeText;
    public bool textBlink = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            if (timeValue < 31)
            {
                timeText.color = Color.magenta;
                StartCoroutine("FlashText");
            }
        }
        else
        {
            //game over
            StopAllCoroutines();
            timeValue += 300;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime (float timeDisplay)
    {
        if(timeDisplay < 0)
        {
            timeDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public IEnumerator FlashText()
    {
        while (textBlink)
        {
            timeText.enabled = false;
            yield return new WaitForSeconds(.5f);
            timeText.enabled = true;
            yield return new WaitForSeconds(.5f);
        }
    }
}
