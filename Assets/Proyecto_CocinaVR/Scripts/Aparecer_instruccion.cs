using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer_instruccion: MonoBehaviour
{

    public GameObject Display;
    public float tiempoMaximo = 0;
    private int bandera = 0; 
  
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Untagged")
        {
            if (bandera==0)
            {
                Display.SetActive(true);
                Invoke("activar", tiempoMaximo);
                bandera++;
            }
           
        }
        

    }

    private void activar()
    {
        Display.SetActive(false);
        //Display2.SetActive(true);  
    }

}
