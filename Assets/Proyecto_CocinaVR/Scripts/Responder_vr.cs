using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Responder_vr : MonoBehaviour{

    public GameObject Display;
    private Text canva_puntos;
    public int puntosPorRespuesta = 0;
    public GameObject Pregunta;
    public GameObject Bien;
    public GameObject Mal;
    private float tiempoMaximo = 5f;
    public static bool flag = false;
    private float tiempo;

    public static int puntos;

   
    void Start()
    {
        //Bien.SetActive(false);
        //Mal.SetActive(false);
        puntos = 0;

        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            puntos += puntosPorRespuesta;

            //canva_puntos.text = "puntos: " + puntos;
            if (puntos != 0)
            {
                //Destroy(Display);
                Mal.SetActive(false);
                Bien.SetActive(true);
                Display.SetActive(false);
                Destroy(Display);
                flag = true;

            }
            else
            {
                Display.SetActive(false);
                Mal.SetActive(true);
                //flag = true;
                Invoke("tiempoSegundos", tiempoMaximo);
                
            }
            //canva_puntos.text = "puntos: " + puntos;
            
        }
    }

    private void Update()
    {

        //tiempoSeguntos();

       
    }


    private void tiempoSegundos()
    {
        /* if (flag == true)
         {

             tiempo += Time.deltaTime;
             if (tiempo >= tiempoMaximo)
             {

                 Mal.SetActive(false);
                 tiempo = 0f;
                 flag = false;
                 Display.SetActive(true);

             }

         }*/

        
        Mal.SetActive(false);
        Display.SetActive(true);

    }





}
