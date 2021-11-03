using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntaShow_VR : MonoBehaviour
{
    public GameObject Display;
    bool flag ;
    //public GameObject objeto;
    void Start()
    {
        Display.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "PlayerInteractionZone")
        {
            //flag = GetComponentInParent<Responder_vr>().flag;

            if (flag != false)
            {
                Display.SetActive(true);
            }
            
            //DontDestroyOnLoad(objeto);
        }

    }
}
