using UnityEngine;


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
