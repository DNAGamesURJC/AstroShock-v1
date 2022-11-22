using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour
{
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
        

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //Se salta
            rigidbody2D.AddForce(new Vector2(0, 200));
            //rigidbody2D.transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
        }

    }

    //Colisiones
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //Si existe colision con el suelo
        if (collision.gameObject.tag == "Suelo")
        {
            //Se pierde
            gamemanager.Gameover = true;
        }
        
        //Si existe colsion con un objeto obstaculo
        if (collision.gameObject.tag == "Obstaculo")
        {
            //Se pierde
            gamemanager.Gameover = true;
        }

        //Si existe colsion con un objeto victoria
        if (collision.gameObject.tag == "Victoria")
        {
            //Se gana
            gamemanager.Victory = true;
            Time.timeScale = 0;
        }




    }
}
