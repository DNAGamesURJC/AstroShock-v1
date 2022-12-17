using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniNivel4 : MonoBehaviour
{
    private Rigidbody2D rigidbody2DNivel4;
    public GameManager gamemanager4;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody para el control del personaje
        rigidbody2DNivel4 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //Se salta
            rigidbody2DNivel4.AddForce(new Vector2(0, 200));
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
            gamemanager4.Gameover = true;
        }

        //Si existe colsion con un objeto obstaculo
        if (collision.gameObject.tag == "Obstaculo")
        {
            //Se pierde
            gamemanager4.Gameover = true;
        }

        //Si existe colsion con un objeto victoria
        if (collision.gameObject.tag == "Victoria")
        {
            //Se gana
            gamemanager4.Victory = true;
            Time.timeScale = 0;
        }




    }
}
