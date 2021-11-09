using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntaShow_VR : MonoBehaviour
{
    public GameObject Display;

    void Start()
    {
        Display.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Activado");
        if (col.tag == "PlayerInteractionZone")
        { 
              Display.SetActive(true);  
        }

    }
}
