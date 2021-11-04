using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieReturn : MonoBehaviour
{
    public ObjectPooler objectPooler;
    public Animator zombieAnimator; 

    // Start is called before the first frame update
    void Start()
    {
        //objectPooler = FindObjectOfType<ObjectPooler>();
    }

    private void OnDisable()
    {
        if (objectPooler != null)
            objectPooler.ReturnZoombie(this.gameObject);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Player"))
        {
            //zombieAnimator.SetBool("die", false);
            OnDisable();
        }
    }

}
