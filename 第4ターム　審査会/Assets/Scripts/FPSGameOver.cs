using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        FadeManager.Instance.LoadScene("FPSResult", 1.0f);
    }
}
