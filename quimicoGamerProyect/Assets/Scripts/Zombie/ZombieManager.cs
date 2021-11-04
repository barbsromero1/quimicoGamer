using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    #region Singleton 

    public static ZombieManager instance;

    private void Awake()
    {
        instance = this; 
    }

    #endregion

    public GameObject player; 

}
