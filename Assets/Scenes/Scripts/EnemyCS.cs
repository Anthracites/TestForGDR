using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCS : MonoBehaviour

{
    private int IsWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Pers")
        {
            Destroy(other.gameObject);

            IsWin = 0;
            #region PlayerPrefs.Set***
            PlayerPrefs.SetInt("IsWin", IsWin);
            #endregion

            SceneManager.LoadScene(4);
        }
    }

}
