using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController.gravityOn = true;
        PlayerController.gravityLeft = false;
        PlayerController.gravityRight = false;
        PlayerController.gravityUp = false;
    }
}
