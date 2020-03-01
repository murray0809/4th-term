using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    /// <summary>表示テキスト</summary>
    [SerializeField] public Text m_console;
    /// <summary>動作中フラグ</summary>
    bool m_isWorking;
    /// <summary>タイマー</summary>
    static public float m_timer;

    void Start()
    {
        m_isWorking = true;
        m_console = GameObject.FindWithTag("Timer").GetComponentInChildren<Text>();
        m_timer = 0;
    }
    void Update()
    {
        if (m_isWorking)
        {
            m_timer += Time.deltaTime;
            Refresh();
        }
    }
    void Refresh()
    {
        m_console.text = m_timer.ToString("F2");    // 小数点以下２桁を表示する
    }
}