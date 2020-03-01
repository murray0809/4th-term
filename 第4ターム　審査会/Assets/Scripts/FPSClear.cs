using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSClear : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        FadeManager.Instance.LoadScene("FPSResult", 1.0f);
    }
}
