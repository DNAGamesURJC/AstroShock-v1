using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [Header("Opciones")]
    public Slider volumeMaster;
    public Toggle mute;
    [Header("Paneles")]
    public GameObject Menu;
    public GameObject Opciones;
    public GameObject Jugar;

   
    //Abrir panel que corresponde al pulsar los botones
    public void OpenPanel(GameObject panel) { 
    Menu.SetActive(false);
    Opciones.SetActive(false);
    Jugar.SetActive(false);
    panel.SetActive(true);
    }

    //Pulsar el boton de nivel cambia de escena
    public void playLevel(string NombreNivel) {
        SceneManager.LoadScene(NombreNivel);
    }
    //Pulsar el boton "Menu Principal" devuelve al menu principal
    public void volver(string Volver) {
        SceneManager.LoadScene(Volver);
    }

    //Pulsar el boton salir sale del juego
    public void exitGame() {
        Application.Quit();
    }




}
