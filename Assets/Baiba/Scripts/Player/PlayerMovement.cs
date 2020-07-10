using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    Transform t;
    public Joystick joystickDirection;
    public Joystick joystickRotation;

    private void Start()
    {
        t = transform;
    }

    private void Update()
    {
        t.Translate(Vector3.forward * joystickDirection.Vertical * speed * Time.deltaTime);
        //t.Translate(Vector3.right * joystickDirection.Horizontal * speed * Time.deltaTime);
        t.Rotate(Vector3.up * joystickRotation.Horizontal * rotationSpeed * Time.deltaTime);
    }
}
