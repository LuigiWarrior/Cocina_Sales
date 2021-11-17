using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones : MonoBehaviour
{
    public GameObject Display;
    public float tiempoMaximo;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            Invoke("Desactivar", tiempoMaximo);
        }
    }

    public void Desactivar()
    {
        Display.SetActive(false);
    }
}
