using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AF_Show : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public bool flag = true;
    void Start()
    {
        Display.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "PlayerInteractionZone" && flag == true)
        {
            Display.SetActive(true);
            flag = false;
            
        }
        
    }
}
