using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sumar : MonoBehaviour
{
    public Text canva_puntos;
    public int puntosPorRespuesta = 0;

    
    private float tiempo;
    public bool flag = false;
    public static int puntos;
    private float tiempoMaximo = 0.1f;
    void Start()
    {
        puntos = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
        Debug.Log(other.tag);
        if (other.tag == "PlayerInteractionZone")
        {
            if (flag == true)
            {
                puntos += puntosPorRespuesta;
                flag = false;
                canva_puntos.text = "" + puntos;
                new WaitForSeconds(0.5f);

            }
        }
        flag = false;
    }
 
}

