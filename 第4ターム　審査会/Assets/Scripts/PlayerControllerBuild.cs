using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBuild : MonoBehaviour
{
    public static float speed = 10.0f;
    public Rigidbody rb;

    public static bool isGrounded;

    [SerializeField] Animator m_anim;

    public Vector3 leftGravity = new Vector3(-9.8f, 0, 0);
    public Vector3 rightGravity = new Vector3(9.8f, 0, 0);
    public Vector3 nomalGravity = new Vector3(0, -9.8f, 0);
    public Vector3 upGravity = new Vector3(0, 9.8f, 0);

    public static bool gravityOn = true;
    public static bool gravityLeft = false;
    public static bool gravityRight = false;
    public static bool gravityUp = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_anim = GetComponent<Animator>();
        gravityOn = true;
        gravityLeft = false;
        gravityRight = false;
        gravityUp = false;

        Physics.gravity = nomalGravity;
    }

    void Update()
    {

        if (Input.GetButtonDown("X"))
        {


            Physics.gravity = leftGravity;

            Invoke("ChangeGravityLeft", 0.5f);


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

    void LateUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        if (!isGrounded)
        {
            z = 0;
        }

        if (gravityOn)
        {
            rb.AddForce(x, 0, z);
        }
        if (gravityUp)
        {
            rb.AddForce(-x, 0, z);
        }
        if (gravityLeft)
        {
            rb.AddForce(0, -x, z);
        }
        if (gravityRight)
        {
            rb.AddForce(0, x, z);
        }

        if (m_anim)
        {
            if (z > 0 || z < 0)
            {
                m_anim.SetBool("Run", true);

            }
            else
            {
                m_anim.SetBool("Run", false);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
        //Debug.Log("接地");
        if (m_anim)
        {
            m_anim.SetBool("Jump", false);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        Debug.Log("空中");
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

    private void OnCollisionEnter(Collision collision)

    {

        // Killzone にぶつかったらゲームオーバー

        if (collision.gameObject.tag == "Killzone")
        {
            GameOver();

        }
    }

    void GameOver()
    {
        gravityOn = true;
        gravityLeft = false;
        gravityRight = false;
        gravityUp = false;
        FadeManager.Instance.LoadScene("TitleBuild", 1.0f);
    }
}
