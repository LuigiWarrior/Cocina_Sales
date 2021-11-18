using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class manager : MonoBehaviour
{
    public int contador=0;
    public int contadoraf = 0;
    public GameObject Display;
    public GameObject DisplayAf;
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
        if (contadoraf == 12)
        {
            DisplayAf.SetActive(true);
        }
    }

}

