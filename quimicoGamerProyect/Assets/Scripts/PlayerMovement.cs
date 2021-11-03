using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float finalSpeed = 0;
    private Vector3 vectorMovement;

    //public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        vectorMovement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        finalSpeed = Time.deltaTime * speed;
        vectorMovement.x = finalSpeed * Input.GetAxis("Horizontal");
        vectorMovement.z = finalSpeed * Input.GetAxis("Vertical");
        this.transform.Translate(vectorMovement);
        //transform.Translate(vectorMovement);
        // transform.position += vectorMovement; 

        //con rb
        //rb.MovePosition(transform-position + vectorMovimiento);
    }
}
