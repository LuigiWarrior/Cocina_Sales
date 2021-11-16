using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones_boton : MonoBehaviour
{
    public GameObject Display;
    public GameObject Display2;
    
    private int bandera = 0;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Untagged")
        {
            if (bandera == 0)
            {
                Display.SetActive(true);
                Display2.SetActive(true);
               
            }
            bandera++;
        }


    }

}
