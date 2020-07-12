using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.player
{
    public class PlayerMovement_DEMO : MonoBehaviour

    {
        public float rotSpeed;
        public float speed;

        void Start()
        {
   
        }

        // Update is called once per frame
        void Update()
        {
           if(Input.GetKey(KeyCode.W))
           {
           transform.Translate(Vector3.forward * speed * Time.deltaTime);
           }
           if(Input.GetKey(KeyCode.S))
           {
           transform.Translate(Vector3.back * speed * Time.deltaTime);
           }
           if(Input.GetKey(KeyCode.D))
           {
           transform.Rotate(new Vector3(0,1,0) * rotSpeed * Time.deltaTime);
           }
           if(Input.GetKey(KeyCode.A))
           {
           transform.Rotate(new Vector3(0,-1,0) * rotSpeed * Time.deltaTime);
           }
        }
      
    }
}
