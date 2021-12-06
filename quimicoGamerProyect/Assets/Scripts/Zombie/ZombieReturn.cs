using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieReturn : MonoBehaviour
{
    public ObjectPooler objectPooler;
    public Animator zombieAnimator;
    public PlayerLivfeSystem personaje;

    // Start is called before the first frame update
    void Start()
    {
        //objectPooler = FindObjectOfType<ObjectPooler>();
    }

    private void OnDisable()
    {
        if (objectPooler != null)
        {
            
            objectPooler.ReturnZoombie(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        int cont = 0;
        if (col.transform.CompareTag("Player"))
        {
            personaje.RemoveLife(20);
        }
        if (col.transform.CompareTag("Bat"))
        {
            cont++;
            if (cont == 3)
            {
                zombieAnimator.SetBool("die", false);
                Invoke("OnDisable", 1f);
                cont = 0;
                Debug.Log("bat");
                return;
            }
            
        }
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.transform.CompareTag("Player"))
        {
            personaje.RemoveLife(1);
        }
    }

}
