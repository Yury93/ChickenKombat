using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : SingletonBase<Player>
{
    [SerializeField] private int m_Lives,m_Score,m_Record;
    [SerializeField] private Text m_LivesTxt, m_ScoreTxt, m_RecordTxt;

    private void Start()
    {
        m_LivesTxt.text = "Lives: "+ m_Lives.ToString();
        m_ScoreTxt.text = "Score: " + m_Score.ToString();
        m_Record = PlayerPrefs.GetInt("NewRecord");
        m_RecordTxt.text = "Record: " + PlayerPrefs.GetInt("NewRecord");
        
    }

    public void PlayerDamage()
    {
        m_Lives -= 1;
        m_LivesTxt.text = "Lives: "+ m_Lives.ToString();
        if (m_Lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void UpdateScore()
    {
        m_Score += 1;
        m_ScoreTxt.text = "Score: " + m_Score.ToString();
        if (m_Score > m_Record)
        {
            PlayerPrefs.SetInt("NewRecord",m_Score);
            m_Record = m_Score;
            m_RecordTxt.text = "Record: " + m_Record.ToString();
        }
    }
}
