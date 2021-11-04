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
        if (horizontalInput != 0)
        {
            if (horizontalInput < 0)
            {
                horizontalInput = (horizontalInput) * (-1);
            }
            animatorPersonaje.SetFloat("JoystickAxis", horizontalInput);
        }
        if (verticalInput != 0)
        {
            if (verticalInput < 0)
            {
                verticalInput = (verticalInput) * (-1);
            }
            animatorPersonaje.SetFloat("JoystickAxis", verticalInput);
        }
        if (Input.GetAxis("Jump") > 0)
        {
            animatorPersonaje.SetTrigger("attack");
        }

    }

    public void Pisada()
    {
        Debug.Log("piso");
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
