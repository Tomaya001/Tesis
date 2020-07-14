using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.player
{
    public class PickUpObjects : MonoBehaviour
    {
        public GameObject ObjectToPickUp;
        public GameObject PickedObject;
        public Transform hand;

        void Agarrar()
        {
            if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObjects>().isPickable)
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<PickableObjects>().isPickable = false;
                PickedObject.transform.SetParent(hand);
                PickedObject.transform.position = hand.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }

        /*void Soltar()
        {   
            PickedObject.GetComponent<PickableObjects>().isPickable = true;
            PickedObject.transform.SetParent(null);
            PickedObject.GetComponent<Rigidbody>().useGravity = true;
            PickedObject.GetComponent<Rigidbody>().isKinematic = false;
            PickedObject = null;            
        }*/

        public void AgarrarBandeja()
        {
            if (ObjectToPickUp.CompareTag("Bandeja"))
            {
                Agarrar();
            }
        }
    }
}

