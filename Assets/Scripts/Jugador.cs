using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    //Variables
    public float salto;
    public bool estaSuelo;
    private Rigidbody2D rigidbody2D;
    public GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si se pulsa el boton izq del raton y esta en el suelo, salta (BUG)
        if (Input.GetKeyDown(KeyCode.Mouse0) && estaSuelo == true) {
            rigidbody2D.AddForce(new Vector2(0, salto));
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si existe colision con el suelo, estaSuelo a true
        if (collision.gameObject.tag == "Suelo")
        {
            estaSuelo = true;
        }
        else {
            estaSuelo = false;
        }
        //Si existe colsion con un objeto obstaculo, se manda al gamemanager
        if (collision.gameObject.tag == "Obstaculo") {
            gamemanager.Gameover = true;
        }

    }



}
