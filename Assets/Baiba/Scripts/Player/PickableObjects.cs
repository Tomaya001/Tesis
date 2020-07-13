using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.player
{
    public class PickableObjects : MonoBehaviour
    {
        public bool isPickable = true;
        public bool isTrash = false;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bandeja"))
            {
                if (isTrash)
                {
                    if(other.gameObject.GetComponent<Bandeja>().bandeja.Equals(null))
                    {
                        other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;
                    }
                    else
                    {
                        Debug.Log("No Puede Entregar Basura");
                    }
                }
                else
                {
                    other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;
                }
                
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Bandeja"))
            {
                other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = null;
            }
        }
    }
}

