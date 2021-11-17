using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class Informacion : MonoBehaviour
{
    public GameObject Display;
	public int intentos = 2;
	public float tiempoMaximo;
	private bool flag = false;
	private float tiempo;
	void Start()
    {
        Display.SetActive (false);
    }

    void OnTriggerEnter(Collider col){

		Debug.Log(col.tag);
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
