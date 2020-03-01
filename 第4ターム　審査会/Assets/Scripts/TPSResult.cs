using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TPSResult : MonoBehaviour
{
    [SerializeField] GameObject arrow1 = default;
    [SerializeField] GameObject arrow2 = default;
    bool up;
    bool down;

    [SerializeField] public Text m_TPSResult;
    [SerializeField] public Text m_TPSHighScore;

    //static float highScore = default;
    void Start()
    {
        arrow1.SetActive(true);
        arrow2.SetActive(false);
        up = true;
        down = false;

        m_TPSResult = GameObject.FindWithTag("TPSResult").GetComponentInChildren<Text>();
        m_TPSHighScore = GameObject.FindWithTag("TPSHighScore").GetComponentInChildren<Text>();

        //highScore = 10;
    }

    
    void Update()
    {
        

        m_TPSResult.text = "SCORE："+ TimerText.m_timer.ToString("F2");

        //if (highScore >= TimerText.m_timer)
        //{
         //   m_TPSHighScore.text = "HIGHSCORE：" + highScore.ToString("F2");
        //}

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
            FadeManager.Instance.LoadScene("TPS", 1.0f);
        }
        if (Input.GetButtonDown("B") && down)
        {
            FadeManager.Instance.LoadScene("Title", 1.0f);
        }

        //highScore = TimerText.m_timer;
    }
}
