using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float maxRight = 10f;
    public float maxLeft = -10f;
    public float speed = 0.5f;
    public bool right = true;
    public Rigidbody rb;

    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = 0;
        movement.x = 0;
        if (right)
        {
            movement.z = speed;
            if (rb.transform.position.z > maxRight)
            {
                right = false;
            }
        }
        else
        {
            if (rb.transform.position.z < maxLeft)
            {
                right = true;
            }
            movement.z = -speed;
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }
}
