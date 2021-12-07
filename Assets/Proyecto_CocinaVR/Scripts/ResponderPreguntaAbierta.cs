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
    public manager manager;
    public bool flag2 = true;
    public Flag flag;

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
                manager.contarpreguntas();
                if (flag.flag == false)
                {
                    manager.contarpreguntaAbierta();
                }
                
                if (flag.flag == true) 
                { 
                    manager.contarpreguntaPrecision();
                }
                
            }
            else
            {
                Pregunta.SetActive(false);
                Mal.SetActive(true);
                Invoke("tiempoSegundos", tiempoMaximo);
                if (flag2 == true)
                {
                    manager.porciento();
                    flag2 = false;
                }
            }
        }
        
    }

    private void tiempoSegundos()
    {
        Mal.SetActive(false);
        Pregunta.SetActive(true);
    }

}
