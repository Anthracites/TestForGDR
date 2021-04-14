using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinFailExit : MonoBehaviour
{
    private int LastWinLevel, IsStarted;
    private int IsWin;
    public Image Status;
    public Sprite[] Statuses;

    void Start()
    {
        #region PlayerPrefs.Get***
        IsWin = PlayerPrefs.GetInt("IsWin");
        #endregion

        LastWinLevel = 0;
        IsStarted = 0;
        if (IsWin == 1)
        {
            Status.sprite = Statuses[0];
        }
        else
        {
            Status.sprite = Statuses[1];
        }

    }
    void SaveStats()
    {
        #region PlayerPrefs.Set***
        PlayerPrefs.SetInt("LastWinLevel", LastWinLevel);
        PlayerPrefs.SetInt("IsStarted", IsStarted);
        #endregion
        Debug.Log("Settings uploaded to Windows Registry");
    }

    public void ContinueAfter()
    {
        SaveStats();
        IsWin = 1;
        SceneManager.LoadScene(0);
    }
}
