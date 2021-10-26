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
        //Bien.SetActive(false);
        //Mal.SetActive(false);
        puntos = 0;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = false;
       
        Debug.Log("Activado");
        
    }
    private void OnTriggerStay(Collider other)
    {
        flag = false;
        Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        flag = true;
        Debug.Log("Exit");
        if (flag == true)
        {
            puntos += puntosPorRespuesta;
            flag = false;
            /*tiempo += Time.deltaTime;
            if (tiempo >= tiempoMaximo)
            {
                tiempo = 0f;
                flag = false;
            }*/
            canva_puntos.text = "puntos: " + puntos;
            new WaitForSeconds(0.5f);

        }



        flag = false;

    }

   

}

