using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange2 : MonoBehaviour
{
    public Vector3 leftGravity = new Vector3(-9.8f, 0, 0);
    public Vector3 rightGravity = new Vector3(9.8f, 0, 0);
    public Vector3 nomalGravity = new Vector3(0, -9.8f, 0);
    public Vector3 upGravity = new Vector3(0, 9.8f, 0);

    public static bool gravityOn = true;
    public static bool gravityLeft = false;
    public static bool gravityRight = false;
    public static bool gravityUp = false;

    [SerializeField] Animator m_anim;

    Rigidbody rb;
   
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("X"))
        {
            

            Physics.gravity = leftGravity;

            Invoke("ChangeGravityLeft", 0.5f);

            m_anim.SetBool("Jump", true);

            gravityOn = false;
            gravityUp = false;
            gravityLeft = true;
            gravityRight = false;

            Debug.Log("重力left");
        }
        if (Input.GetButtonDown("B"))
        {
            

            Physics.gravity = rightGravity;
            rb.AddForce(rightGravity, ForceMode.Acceleration);

            Invoke("ChangeGravityRight", 0.5f);

            gravityOn = false;
            gravityUp = false;
            gravityLeft = false;
            gravityRight = true;

            Debug.Log("重力right");
        }
        if (Input.GetButtonDown("A"))
        {
            

            Physics.gravity = nomalGravity;
            rb.AddForce(nomalGravity, ForceMode.Acceleration);

            Invoke("ChangeGravityNomal", 0.5f);

            gravityOn = true;
            gravityUp = false;
            gravityLeft = false;
            gravityRight = false;
            Debug.Log("重力on");
        }
        if (Input.GetButtonDown("Y"))
        {
            

            Physics.gravity = upGravity;
            rb.AddForce(upGravity, ForceMode.Acceleration);

            Invoke("ChangeGravityUp", 0.5f);

            gravityOn = false;
            gravityUp = true;
            gravityLeft = false;
            gravityRight = false;
            Debug.Log("重力up");
        }
    }

    void ChangeGravityLeft()
    {
        transform.rotation = Quaternion.AngleAxis(-90, new Vector3(0f, 0f, 1f));
    }
    
    void ChangeGravityRight() 
    {
        transform.rotation = Quaternion.AngleAxis(90, new Vector3(0f, 0f, 1f));
    }

    void ChangeGravityNomal()
    {
        transform.rotation = Quaternion.AngleAxis(0, new Vector3(0f, 0f, 1f));
    }

    void ChangeGravityUp()
    {
        transform.rotation = Quaternion.AngleAxis(180, new Vector3(0f, 0f, 1f));
    }
}
