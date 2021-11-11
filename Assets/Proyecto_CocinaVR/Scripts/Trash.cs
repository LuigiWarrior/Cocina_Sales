using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

    public GameObject alimento;
    public GameObject poscicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Trash"))
        {
            Destroy(gameObject, .1f);
            Instantiate(alimento, poscicion.transform.position, poscicion.transform.rotation).name = alimento.name;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
