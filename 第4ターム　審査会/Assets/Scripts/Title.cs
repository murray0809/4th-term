using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    [SerializeField] GameObject arrow1 = default;
    [SerializeField] GameObject arrow2 = default;
    bool up;
    bool down;
    void Start()
    {
        arrow1.SetActive(true);
        arrow2.SetActive(false);
        up = true;
        down = false;
    }

    
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        if (z > 0)
        {
            arrow1.SetActive(true);
            arrow2.SetActive(false);
            up = true;
            down = false;
        }
        if (z < 0)
        {
            arrow1.SetActive(false);
            arrow2.SetActive(true);
            up = false;
            down = true;
        }
        if (Input.GetButtonDown("B") && up)
        {
            FadeManager.Instance.LoadScene("FPS", 1.0f);
        }
        if (Input.GetButtonDown("B") && down)
        {
            FadeManager.Instance.LoadScene("TPS", 1.0f);
        }
    }
}
