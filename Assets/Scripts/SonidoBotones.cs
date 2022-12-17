using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotones : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundBoton;

    public void SonidoBoton() {
        sound.clip = soundBoton;
        sound.enabled = false;
        sound.enabled = true;
    }
}
