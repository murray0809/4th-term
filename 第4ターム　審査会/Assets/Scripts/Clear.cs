using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        FadeManager.Instance.LoadScene("TPSResult", 1.0f);
    }
}
