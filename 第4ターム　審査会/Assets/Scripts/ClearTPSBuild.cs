using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTPSBuild : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        FadeManager.Instance.LoadScene("TPSResultBuild", 1.0f);
    }
}
