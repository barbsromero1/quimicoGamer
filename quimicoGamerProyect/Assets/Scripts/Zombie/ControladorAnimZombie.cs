using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimZombie : MonoBehaviour
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
        
    }
    public void Pisada()
    {
        Debug.Log("piso");
        fuenteAudio.PlayOneShot(sonidoPasos);
    }
}
