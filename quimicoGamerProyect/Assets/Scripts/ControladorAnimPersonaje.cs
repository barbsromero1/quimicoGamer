using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimPersonaje : MonoBehaviour
{
    public Animator animatorPersonaje;
    public AudioSource fuenteAudio;
    public AudioClip sonidoPasos;

    private bool hasWeapon;

    // Start is called before the first frame update
    void Start()
    {
        hasWeapon = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pisada()
    {
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
