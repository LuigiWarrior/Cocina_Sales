using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class manager : MonoBehaviour
{
    public int contador=0;
    public int contadoraf = 0;
    public int contadorporciento = 0;
    public int contadorpreguntas = 0;
    public int contadorabiertas = 0;
    public GameObject Display;
    public GameObject DisplayAf;
    public GameObject DisplayPasas;
    public GameObject DisplayNoPasas;
    public void contar() {
        

        contador++;
        if (contador == 16)
        {
            Display.SetActive(true);
        }
    }

    public void contaraf()
    {
        contadoraf++;
        if (contadoraf == 10)
        {
            DisplayAf.SetActive(true);
        }
    }

    public void contarpreguntas()
    {
        contadorpreguntas++;
        if (contadorpreguntas == 8)
        {
            Display.SetActive(true);
        }
        if ((contadorpreguntas == 13) && contadorporciento<4)
        {
            DisplayPasas.SetActive(true);
            Invoke("DesactivarDisplay", 5);

        }
        if ((contadorpreguntas == 13) && contadorporciento>=4)
        {
            DisplayNoPasas.SetActive(true);
            Invoke("DesactivarDisplay", 5);

        }

    }

    public void porciento()
    {
        contadorporciento++;
        
    }

    public void contarpreguntaAbierta()
    {
        contadorabiertas++;
        if (contadorabiertas == 8 && contadorporciento <3)
        {
            DisplayPasas.SetActive(true);
            Invoke("DesactivarDisplay", 5);
        }
        if (contadorabiertas == 8 && contadorporciento >= 3)
        {
            DisplayNoPasas.SetActive(true);
            Invoke("DesactivarDisplay", 5);
        }
    }

    public void DesactivarDisplay()
    {
        DisplayPasas.SetActive(false);
        DisplayNoPasas.SetActive(false);
    }
}

