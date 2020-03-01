using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public static float speed = 10.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        //if (!IsGrounded.isGrounded)
        //{
        //    z = 0;
        //}

        if (GravityChange2.gravityOn)
        {
            rb.AddForce(0, 0, z);
        }
        if (GravityChange2.gravityUp)
        {
            rb.AddForce(0, 0, z);
        }
        if (GravityChange2.gravityLeft)
        {
            rb.AddForce(0, 0, z);
        }
        if (GravityChange2.gravityRight)
        {
            rb.AddForce(0, 0, z);
        }
    }
}
