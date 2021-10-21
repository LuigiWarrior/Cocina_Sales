using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntaShow_VR : MonoBehaviour
{
    public GameObject Display;
    public GameObject objeto;
    void Start()
    {
        Display.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "PlayerInteractionZone")
        {
            Display.SetActive(true);
            DontDestroyOnLoad(objeto);
        }

    }
}
