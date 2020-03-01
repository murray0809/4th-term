using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSClearBuild : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        FadeManager.Instance.LoadScene("FPSResultBuild", 1.0f);
    }
}
