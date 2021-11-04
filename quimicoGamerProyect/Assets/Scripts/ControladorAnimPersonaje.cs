using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimPersonaje : MonoBehaviour
{
    public Animator animatorPersonaje;
    public AudioSource fuenteAudio;
    public AudioClip sonidoPasos;
    public float PlayerSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        animatorPersonaje.SetFloat("JoystickAxis", horizontalInput);
        animatorPersonaje.SetFloat("JoystickAxis2", verticalInput);

        animatorPersonaje.SetLayerWeight(1, Input.GetAxis("Jump"));

        //if (Input.GetAxis("Jump") > 0)
        //{
        //    animatorPersonaje.SetLayerWeight(1, Input.GetAxis("Jump"));
        //    animatorPersonaje.SetTrigger("attack");
        //}
        
}

    public void Pisada()
    {
        Debug.Log("piso");
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
