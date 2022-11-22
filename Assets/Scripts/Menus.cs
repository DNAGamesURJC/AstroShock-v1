using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class Menus : MonoBehaviour
{
    [Header("Opciones")]
    public Slider volMaster;
    public Toggle mute;
    public AudioMixer mixer;
    private float lastSound;
    [Header("Paneles")]
    public GameObject Menu;
    public GameObject Opciones;
    public GameObject Jugar;
    public GameObject Tienda;
    public GameObject Contactos;
    public GameObject Controles;

    private void Awake() {
        volMaster.onValueChanged.AddListener(CambioVol);
    }
    
    

    //Sonido
    public void CambioVol(float v) {    
        mixer.SetFloat("Volumen", v);
    }
    public void setMute() {   
        if (mute.isOn)
        {
            mixer.GetFloat("Volumen", out lastSound);
            mixer.SetFloat("Volumen", -80);
        }
        else {
            mixer.SetFloat("Volumen", lastSound);
        }
    }


    //Abrir panel que corresponde al pulsar los botones
    public void OpenPanel(GameObject panel)
    {
        Menu.SetActive(false);
        Opciones.SetActive(false);
        Jugar.SetActive(false);
        Tienda.SetActive(false);
        Contactos.SetActive(false);
        Controles.SetActive(false);
        panel.SetActive(true);
    }

    //Pulsar el boton de nivel cambia de escena
    public void playLevel(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }
    //Pulsar el boton "Menu Principal" devuelve al menu principal
    public void volver(string Volver)
    {
        SceneManager.LoadScene(Volver);
    }

    //Pulsar el boton salir, sale del juego
    public void exitGame()
    {
        Application.Quit();
    }
}
     
   
