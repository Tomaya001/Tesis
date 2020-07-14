using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObjectforBandeja : MonoBehaviour
{
    public bool isPickable = true;
    public bool isTrash = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bandeja"))
        {                
            other.GetComponentInParent<PickUpBandeja>().ObjectToPickUp = this.gameObject;                
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Bandeja"))
        {
            other.GetComponentInParent<PickUpBandeja>().ObjectToPickUp = null;
        }
    } 
}
