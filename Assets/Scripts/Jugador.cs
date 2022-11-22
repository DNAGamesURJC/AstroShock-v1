using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    //Variables
    public float salto;
    public float contSaltos = 0f;
    public bool estaSuelo;
    private Rigidbody2D rigidbody2D;
    public GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody para el control del personaje
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //Si se pulsa el boton dcho del raton y esta en el suelo
        if (Input.GetKeyDown(KeyCode.Mouse1) && estaSuelo == true) {
            //Se salta
            rigidbody2D.AddForce(new Vector2(0, salto));
            //No esta en el suelo
            estaSuelo = false;
            //Se suma uno al contador
            contSaltos = contSaltos + 1f;
        }
        //Salto doble
        //Si se pulsa el boton izq del raton y no esta en el suelo y el contador es inferior a 2
        if (Input.GetKeyDown(KeyCode.Mouse0) && estaSuelo == false && contSaltos < 2f) {
            //Se salta
            rigidbody2D.AddForce(new Vector2(0, salto));
            //Se suma otro al contador
            contSaltos = contSaltos + 1f;
        }

    }

    //Colisiones
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si existe colision con el suelo
        if (collision.gameObject.tag == "Suelo")
        {
            //Esta en el suelo
            estaSuelo = true;
            //Contador de saltos a cero
            contSaltos = 0f;
        }
        //Si no
        else {
            //No esta en el suelo
            estaSuelo = false;
        }

        //Si existe colsion con un objeto obstaculo
        if (collision.gameObject.tag == "Obstaculo") {
            //Se pierde
            gamemanager.Gameover = true;
        }

        //Si existe colsion con un objeto victoria
        if (collision.gameObject.tag == "Victoria") {
            //Se gana
            gamemanager.Victory = true;
            Time.timeScale = 0;
        }

    


    }



}
