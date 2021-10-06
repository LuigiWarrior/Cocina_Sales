using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Informacion : MonoBehaviour
{
    public GameObject Display;
	private int intentos = 2;
	public float tiempoMaximo;
	private bool flag = false;
	private float tiempo;
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
					flag = true;
					intentos--;
				}
			break;
		}
		
	}
	/*void OnTriggerExit(Collider col){
		
		switch (col.gameObject.tag){
		case "PlayerInteractionZone":
            Display.SetActive (false);
			break;
		}
	
	}*/
	private void Update()
	{

		if (flag == true)
		{

			tiempo += Time.deltaTime;
			if (tiempo >= tiempoMaximo)
			{
				Display.SetActive(false);
				tiempo = 0f;
				flag = false;
			}
		}


	}
}
