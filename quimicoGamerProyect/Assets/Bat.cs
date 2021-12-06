using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(222, 48);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
