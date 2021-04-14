using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelConmlited : MonoBehaviour
{
    private int LastWinLevel;
    private int CurrentNumberLevel;
    private int IsWin;
    public bool IsTakenKey = false;

    void Awake()
    {

        #region PlayerPrefs.Get***
        LastWinLevel = PlayerPrefs.GetInt("LastWinLevel");
        #endregion
        Debug.Log("Settings downloaded from Windows Registry");
        CurrentNumberLevel = SceneManager.GetActiveScene().buildIndex; 
    }

   void OnTriggerEnter(Collider other)
    {

        if ((other.name == "Pers")&(other.GetComponent<PersStats>().IsKeyTaked == true))
        {
            SceneManager.LoadScene(CurrentNumberLevel + 1);
            IsWin = 1;
            PlayerPrefs.SetInt("IsWin", IsWin);
            SaveStats();
        }
        else
        {

        }
    }

    void SaveStats()
    {
        #region PlayerPrefs.Set***
        PlayerPrefs.SetInt("LastWinLevel", CurrentNumberLevel);
        #endregion
        Debug.Log("Settings uploaded to Windows Registry");
    }
}
