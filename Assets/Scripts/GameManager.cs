using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public Renderer fondo;
    public GameObject pinchopeq;
    public GameObject pinchogr;
    public bool Gameover = false;
    public GameObject GameOver;
    public float velocidad = 2;

    //Lista de los pinchos
    public List<GameObject> obst;
    // Start is called before the first frame update
    void Start()
    {
        //Instanciado de los pinchos
        obst.Add(Instantiate(pinchopeq, new Vector2(14, -2), Quaternion.identity));
        obst.Add(Instantiate(pinchogr, new Vector2(20, -2), Quaternion.identity));


    }

    // Update is called once per frame
    void Update()
    {
        //El fondo se mueve
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f,0)*Time.deltaTime;

        //Si no se ha perdido, no sale el GameOver
        if (Gameover == false) {
            GameOver.SetActive(false);
            //Si no se ha perdido, el juego funciona
            Time.timeScale = 1;
        //Si se ha perdido, sale el GameOver
        } else if (Gameover == true) {
            GameOver.SetActive(true);
            //Si se ha perdido, el juego se pausa
            Time.timeScale = 0;
        }

        //PRUEBA, genera infinitamente un pincho pequeño y otro grande
        for (int i = 0; i<obst.Count;i++) {

            if (obst[i].transform.position.x <= -10) {
                float RandomObst = Random.Range(11, 18);
                obst[i].transform.position = new Vector3(RandomObst, -2, 0);
            }

            obst[i].transform.position = obst[i].transform.position + new Vector3(-1,0,0) * Time.deltaTime * velocidad;
        }




    }
}
