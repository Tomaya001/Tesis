using com.baiba.core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.player
{
    public class PickableObjects : MonoBehaviour
    {
        [Header("Opciones")]
        public TAGS Interaccion;
        public bool isPickable = true;
        [HideInInspector]
        public bool isTrash = false;
        string selectTag;

        public enum TAGS
        {
            Player,
            Bandeja,
        }

        private void Start()
        {
            switch (Interaccion)
            {
                case TAGS.Player:
                    selectTag = Const.TAG.HAND;
                    break;
                case TAGS.Bandeja:
                    selectTag = Const.TAG.BANDEJA;
                    break;
                default:
                    break;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(selectTag))
            {                
                other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(selectTag))
            {
                other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = null;
            }
        }
    }
}

