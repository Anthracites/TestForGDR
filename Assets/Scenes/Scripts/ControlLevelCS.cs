using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLevelCS : MonoBehaviour
{
    public void GoToMenu()
    {
            SceneManager.LoadScene(0);
    }
}
