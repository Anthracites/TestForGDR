using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersEnble : MonoBehaviour
{
    public GameObject PersObj;

    void Start()
    {
        StartCoroutine(MakePersEnable());
    }

    private IEnumerator MakePersEnable()

    
        {
        yield return new WaitForSeconds(1);
        PersObj.SetActive(true);
        }
}
