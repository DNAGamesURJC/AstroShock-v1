using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public Renderer fondo;
    public bool Gameover = false;
    public GameObject GameOver;
    public float velocidad = 2;
    public bool Pausado = false;
    public GameObject Pausa;
    public GameObject Opciones;
    public bool Victory = false;
    public GameObject Victoria;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //El fondo se mueve
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f,0)*Time.deltaTime;

        //Si no se ha ganado y no se ha pausado
        if (Victory == false && Pausado == false)
        {
            //No aparece la pantalla de victoria
            Victoria.SetActive(false);
            //El boton de pausa aparece
            Pausa.SetActive(true);
            //No aparece la pantalla de pausa
            Opciones.SetActive(false);
            //El tiempo sigue corriendo
            Time.timeScale = 1;

            //Si no se ha ganado y se ha pausado
        }
        else if (Victory == false && Pausado == true)
        {
            //Desaparece el boton de pausa
            Pausa.SetActive(false);
            //Aparece la pantalla de pausa
            Opciones.SetActive(true);
            //El tiempo se para
            Time.timeScale = 0;

            //Si se ha ganado
        }
        else if (Victory == true)
        {
            //Aparece la pantalla de victoria
            Victoria.SetActive(true);
            //Se pausa el movimiento
            Pausado = true;
            //El tiempo se para
            Time.timeScale = 0;
        }

        //Si no se ha perdido y no se ha pausado
        if (Gameover == false && Pausado == false) {
            //No aparece la pantalla de GameOver
            GameOver.SetActive(false);
            //El boton de pausa aparece
            Pausa.SetActive(true);
            //No aparece la pantalla de pausa
            Opciones.SetActive(false);
            //El tiempo sigue corriendo
            Time.timeScale = 1;

            //Si no se ha perdido y se ha pausado
        } else if (Gameover == false && Pausado == true) {
            //Desaparece el boton de pausa
            Pausa.SetActive(false);
            //Aparece la pantalla de pausa
            Opciones.SetActive(true);
            //El tiempo se para
            Time.timeScale = 0;

            //Si se ha perdido
        } else if (Gameover == true) {
            //Aparece la pantalla de GameOver
            GameOver.SetActive(true);
            //Se pausa el movimiento
            Pausado = true;
            //El tiempo se para
            Time.timeScale = 0;
        }




    }
}
