using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionTextBuild : MonoBehaviour
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
        if (PlayerControllerBuild.gravityOn)
        {
            nomalGravityText.SetActive(true);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(false);
        }
        if (PlayerControllerBuild.gravityUp)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(true);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(false);
        }
        if (PlayerControllerBuild.gravityLeft)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(true);
            rightGravityText.SetActive(false);
        }
        if (PlayerControllerBuild.gravityRight)
        {
            nomalGravityText.SetActive(false);
            upGravityText.SetActive(false);
            leftGravityText.SetActive(false);
            rightGravityText.SetActive(true);
        }
    }
}
