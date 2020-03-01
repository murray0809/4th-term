using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + transform.up * 1f, -transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (transform.position.y > hit.point.y + 0.01f)
            {
                transform.Translate(0f, -0.15f, 0f);
            }
        }
    }
}
