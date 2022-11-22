using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausado : MonoBehaviour
{
    //Variables
    public GameObject botonPausa;
    public GameObject Ajustes;
    public GameManager gamemanager;

    //Metodo pausar
    public void PausarJuego()
        {
        //Pausado a true
        gamemanager.Pausado = true;
        }

    //Metodo reanudar
    public void Reanudar()
        {
        //Pausado a false
        gamemanager.Pausado = false;
        }

    

    

}
