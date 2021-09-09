using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Informacion : MonoBehaviour
{
    public GameObject Display;
	private int intentos = 2;
    void Start()
    {
        Display.SetActive (false);
    }

    void OnTriggerEnter(Collider col){
		
		
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
				if (intentos > 0)
				{
					Display.SetActive(true);
					intentos--;
				}
			break;
		}
		
	}
	void OnTriggerExit(Collider col){
		
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
            Display.SetActive (false);
			break;
		}
	
	}
}
