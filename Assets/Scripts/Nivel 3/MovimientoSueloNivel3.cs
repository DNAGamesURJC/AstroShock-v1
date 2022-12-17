using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSueloNivel3 : MonoBehaviour
{
    //Variables
    public GameManager gamemanager3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Si se ha pausado
        if (gamemanager3.Pausado == true)
        {
            //El tiemp se para
            Time.timeScale = 0;
        }
        //Si no
        else
        {
            //El objeto se mueve en x
            transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
        }
    }
}
