using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimPersonaje : MonoBehaviour
{
    public Animator animatorPersonaje;
    public AudioSource fuenteAudio;
    public AudioClip sonidoPasos;
    public float PlayerSpeed = 5;
    public GameObject bat;

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
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            bat.SetActive(true);
        }
        if(Input.GetKeyUp("space"))
        {
            bat.SetActive(false);
        }

    }

    public void Pisada()
    {
        Debug.Log("piso");
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
