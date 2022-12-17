using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNivelNivel2 : MonoBehaviour
{
    //Variables
    public GameManager gamemanager2;
    public bool muerte2 = false;

    // Update is called once per frame
    void Update()
    {
        //Si se ha pausado o se ha muerto
        if (gamemanager2.Pausado == true || muerte2 == true)
        {
            //Se para el tiempo
            Time.timeScale = 0;
        }
        //Si no
        else
        {
            //El objeto se mueve en x
            transform.position = new Vector3(transform.position.x - 0.085f, transform.position.y, transform.position.z);
        }
    }

    //Colisiones
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si colisiona con el personaje
        if (collision.gameObject.tag == "Personaje")
        {
            //Se pierde
            gamemanager2.Gameover = true;
            //Se pausa el movimiento
            gamemanager2.Pausado = true;
            //Controlador a true
            muerte2 = true;
        }
    }
}
