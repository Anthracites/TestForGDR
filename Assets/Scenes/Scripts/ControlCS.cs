using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlCS : MonoBehaviour
{
    private int IsStarted = 0;
    private int LastWinLevel;
    public Button ContinueButton;

    void Awake()
    {
        #region PlayerPrefs.Get***
        LastWinLevel = PlayerPrefs.GetInt("LastWinLevel");
        IsStarted = PlayerPrefs.GetInt("IsStarted");
        #endregion
        Debug.Log("Settings downloaded from Windows Registry");

        if (IsStarted == 0)
        {
            ContinueButton.interactable = false;
        }
    }

    public void StartGame()
    {

            SceneManager.LoadScene(1);
            IsStarted = 1;

        SaveStats();
    }

    public void ContinueGame()
    {

            SceneManager.LoadScene(LastWinLevel + 1);

        SaveStats();
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void SaveStats()
    {
        #region PlayerPrefs.Set***
        PlayerPrefs.SetInt("LastWinLevel", LastWinLevel);
        PlayerPrefs.SetInt("IsStarted", IsStarted);
        #endregion
        Debug.Log("Settings uploaded to Windows Registry");
    }
}

