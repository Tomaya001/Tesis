using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.baiba.player
{ 
public class bulletBasedObject : MonoBehaviour
{
    public int size;
    public float time;
    public GameObject inst;
    private int currentAmount;
    public bool isPickable = true;

    void Start()
    {
        currentAmount = size;
    }
    public void TakeObject()
    {
        currentAmount--;

    }
    IEnumerator Replenish()
    {

        return null;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Cambiar por el tag de la Bandeja
        if (other.CompareTag("Hand"))
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToTake = inst;
        }
    }

    private void OnTriggerExit(Collider other)
    {
         //Cambiar por el tag de la Bandeja
        if (other.CompareTag("Hand"))
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToTake = null;
        }
    }
}
}
