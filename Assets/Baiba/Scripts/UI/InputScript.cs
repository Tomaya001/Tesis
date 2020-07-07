using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;

    public Transform contorno;
    public Transform center;

    private bool touchStar = false;
    private Vector2 pointA;
    private Vector2 pointB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            Debug.Log("Point: " + Input.mousePosition);

            center.transform.position = new Vector3(pointA.x *-1, pointA.y/2, 0f);
            contorno.transform.position = new Vector3(pointA.x *-1, pointA.y/2, 0f);
            center.GetComponent<SpriteRenderer>().enabled = true;
            contorno.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (Input.GetMouseButton(0))
        {
            touchStar = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStar = false;
        }
    }

    private void FixedUpdate()
    {
        if (touchStar)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);
        }
        else
        {
            center.GetComponent<SpriteRenderer>().enabled = false;
            contorno.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void moveCharacter(Vector2 direction)
    {
        player.Translate(Vector3.forward * direction.y * speed * Time.deltaTime * -1f);
        player.Translate(Vector3.right * direction.x * speed * Time.deltaTime * -1f);
    }
}
