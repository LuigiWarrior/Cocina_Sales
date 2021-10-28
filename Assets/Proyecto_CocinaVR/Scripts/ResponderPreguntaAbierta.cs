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
                    }
                    else
                    {
                        Mal.SetActive(true);
                    }

                    Destroy(Pregunta);

        }
        
    }
}
