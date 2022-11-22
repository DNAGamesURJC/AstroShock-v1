using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNivel22 : MonoBehaviour
{
    //Variables
    public GameManager gamemanager;
    public bool muerte = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si se ha pausado o se ha muerto
        if (gamemanager.Pausado == true || muerte == true)
        {
            //Se para el tiempo
            Time.timeScale = 0;
        }
        //Si no
        else 
        {
            //El objeto se mueve en x
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }   
    }

    //Colisiones
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si colisiona con el personaje
        if (collision.gameObject.tag == "Personaje")
        {
            //Se pierde
            gamemanager.Gameover = true;
            //Se pausa el movimiento
            gamemanager.Pausado = true;
            //Controlador a true
            muerte = true;
        }
    }
}
