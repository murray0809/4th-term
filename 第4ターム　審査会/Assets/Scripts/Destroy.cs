using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Disappear", 2);
    }

    void Disappear()
    {
        Destroy(gameObject);
    }
}
