using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public static bool isGrounded;
    [SerializeField] Animator m_anim;

    void Start()
    {

    }

    void Update()
    {
        if (m_anim)
        {
            if (!IsGrounded.isGrounded)
            {
                m_anim.SetBool("Jump", true);
            }
            else
            {
                m_anim.SetBool("Jump", false);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
        //Debug.Log("接地");

    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
        Debug.Log("空中");
    }
}
