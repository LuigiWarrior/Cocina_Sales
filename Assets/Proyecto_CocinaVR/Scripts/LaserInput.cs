using UnityEngine;
using Valve.VR;

public class LaserInput : MonoBehaviour
{
    public static GameObject currentObject;
    int currentID;

    void Start()
    {
        currentObject = null;
        currentID = 0;
    }

    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);

        for(int i=0; i<hits.Length;i++)
        {
            RaycastHit hit = hits[i];

            int id = hit.collider.gameObject.GetInstanceID();

            if(currentID != id)
            {
                currentID = id;
                currentObject = hit.collider.gameObject;


                string name = currentObject.name;
                if (name == "Next")
                {
                    Debug.Log("HIT NEXT");
                }

                string tag = currentObject.tag;
                if(tag == "Button")
                {
                    Debug.Log("HIT BUTTON");
                    
                }
            }
        }
    }
}
