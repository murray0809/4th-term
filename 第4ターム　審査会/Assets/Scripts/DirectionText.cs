using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionText : MonoBehaviour
{
    [SerializeField] GameObject nomalGravityText = default;
    [SerializeField] GameObject upGravityText = default;
    [SerializeField] GameObject leftGravityText = default;
    [SerializeField] GameObject rightGravityText = default;

    void Start()
    {
        nomalGravityText.SetActive(true);
        upGravityText.SetActive(false);
        leftGravityText.SetActive(false);
        rightGravityText.SetActive(false);
    }

    void Update()
    {
        if (PlayerController.gravityOn)
        {
            nomalGravityText.SetActive(true);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(false);
        }
        if (PlayerController.gravityUp)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(true);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(false);
        }
        if (PlayerController.gravityLeft)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(true);
            rightGravityText.SetActive(false);
        }
        if (PlayerController.gravityRight)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(true);
        }
    }
}
