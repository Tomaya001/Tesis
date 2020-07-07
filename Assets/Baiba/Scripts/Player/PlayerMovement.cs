using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Transform t;
    public Joystick joystick;

    private void Start()
    {
        t = transform;
    }

    private void Update()
    {
        t.Translate(Vector3.forward * joystick.Vertical * speed * Time.deltaTime);
        t.Translate(Vector3.right * joystick.Horizontal * speed * Time.deltaTime);
    }
}
