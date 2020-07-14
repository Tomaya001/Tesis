using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.player
{
    public class PickableObjects : MonoBehaviour
    {
        public bool isPickable = true;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Hand"))
            {                
                other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;                
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Hand"))
            {
                other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = null;
            }
        }
    }
}

