using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieReturn : MonoBehaviour
{
    private ObjectPooler objectPooler;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = FindObjectOfType<ObjectPooler>();
    }

    private void OnDisable()
    {
        if (objectPooler != null)
            objectPooler.ReturnZoombie(this.gameObject);
    }

}
