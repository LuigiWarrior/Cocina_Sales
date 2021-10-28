using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Responder_vr : MonoBehaviour{
    
    
    public Text canva_puntos;
    public int puntosPorRespuesta = 0;
    public GameObject Pregunta;
    public GameObject Bien;
    public GameObject Mal;

    public static int puntos;

   
    void Start()
    {
        //Bien.SetActive(false);
        //Mal.SetActive(false);
        puntos = 0;
    }

   

    private void OnTriggerEnter(Collider other)
    {
        puntos += puntosPorRespuesta;

        //canva_puntos.text = "puntos: " + puntos;
        if (puntos == 1)
        {
            Bien.SetActive(true);
            puntos = 0;
        }
        else
        {
            Mal.SetActive(true);
            puntos = 0;
        }
        //canva_puntos.text = "puntos: " + puntos;
        Destroy(Pregunta);
    }
}
