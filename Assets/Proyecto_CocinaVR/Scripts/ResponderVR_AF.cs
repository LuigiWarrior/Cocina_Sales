using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponderVR_AF : MonoBehaviour
{
    public GameObject Display;
    public int puntosPorRespuesta = 0;
    public GameObject Bien;
    public GameObject Mal;
    private float tiempoMaximo = 2f;
    public static bool flag2 = false;
    public static int puntos;
    public manager manager;
    public Flag flag;

    void Start()
    {
        puntos = 0;

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "PlayerInteractionZone")
        {
            Debug.Log("Activado");
            puntos += puntosPorRespuesta;

            if (puntos != 0)
            {
                Bien.SetActive(true);
                Display.SetActive(false);
                manager.contarpreguntas();
                
            }
            else
            {
                Display.SetActive(false);
                Mal.SetActive(true);
                Invoke("tiempoSegundos", tiempoMaximo);
                if (flag.flag == true)
                {
                    manager.porciento();
                    flag.flag = false;
                }

            }
        }
    }

    private void tiempoSegundos()
    {
        Mal.SetActive(false);
        Display.SetActive(true);
    }
}
