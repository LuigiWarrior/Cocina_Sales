using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResponderPreguntaAbierta : MonoBehaviour
{
    public GameObject Pregunta;
    public GameObject Bien;
    public GameObject Mal;
    public string RespuestaCorrecta;
    public Text puntos;
    private float tiempoMaximo = 2f;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            if (puntos.text==RespuestaCorrecta)
            {
                Bien.SetActive(true);
                Pregunta.SetActive(false);
            }
            else
            {
                Pregunta.SetActive(false);
                Mal.SetActive(true);
                Invoke("tiempoSegundos", tiempoMaximo);
            }
        }
        
    }

    private void tiempoSegundos()
    {
        Mal.SetActive(false);
        Pregunta.SetActive(true);
    }

}
