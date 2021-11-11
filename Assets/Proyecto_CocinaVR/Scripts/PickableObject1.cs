
using UnityEngine;
using UnityEngine.UI;
public class PickableObject1 : MonoBehaviour
{
    /*public bool isPickable = true;
    public float saltQuantity = 0;
    public Text saltAcumulatedUI;
    public Text menu;
    private float SaltAcumulated = 0;
    public GameObject Plato;
    private string comidaActual = "";
    public GameObject alimento;
    public GameObject poscicion;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerInteractionZone"))
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToPickup = this.gameObject;

        }



        if (other.CompareTag("Dish"))
        {
            
            Plato.GetComponent<SaltCounter>().acumulatedSalt += saltQuantity;
            SaltAcumulated = Plato.GetComponent<SaltCounter>().acumulatedSalt;
            saltAcumulatedUI.text = ("Azucar acumulada: " + SaltAcumulated.ToString());
            comidaActual = gameObject.name;
            menu.text = menu.text + "\n" + comidaActual;
            Destroy(gameObject, .5f);
            Instantiate(alimento,poscicion.transform.position, poscicion.transform.rotation).name=alimento.name;

        }

    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerInteractionZone"))
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToPickup = null;

        }

        if (other.CompareTag("Dish"))
        {

            Plato.GetComponent<SaltCounter>().acumulatedSalt -= saltQuantity;
            SaltAcumulated = Plato.GetComponent<SaltCounter>().acumulatedSalt;
            saltAcumulatedUI.text = ("Sal acumulada: " + SaltAcumulated.ToString());
        }
    }*/

}
