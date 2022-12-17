using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaNivel4 : MonoBehaviour
{
    //Variables
    public GameManager gamemanager4;
    public bool ganado4 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Si se ha pausado o se ha muerto
        if (gamemanager4.Pausado == true || ganado4 == true)
        {
            //Se para el tiempo
            Time.timeScale = 0;
        }
        //Si no
        else
        {
            //El objeto se mueve en x
            transform.position = new Vector3(transform.position.x - 0.6f, transform.position.y, transform.position.z);
        }
    }

    //Colisiones
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si colisiona con el personaje
        if (collision.gameObject.tag == "Personaje")
        {
            //Se pierde
            gamemanager4.Victory = true;
            //Controlador a true
            ganado4 = true;
        }
    }
}
