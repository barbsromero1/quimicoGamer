using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifeUi : MonoBehaviour
{
    public RectTransform lifebar;
    public PlayerLivfeSystem playerLifeSystem;
    public int life=200;
    private int height = 48;
    // Start is called before the first frame update
    void Start()
    {
        life = playerLifeSystem.lives;
    }

    // Update is called once per frame
    void Update()
    {
        life=playerLifeSystem.lives;
        lifebar.sizeDelta = new Vector2(life, height);
    }
}
