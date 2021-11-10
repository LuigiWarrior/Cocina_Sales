using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;


public class preguntaShow_VR : MonoBehaviour
{
    public GameObject Display;

    void Start()
    {
        Display.SetActive(false);
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);
        if (col.CompareTag("PlayerInteractionZone"))
        { 
              Display.SetActive(true);  
        }

    }
}
