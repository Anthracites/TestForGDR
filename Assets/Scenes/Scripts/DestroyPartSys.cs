using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPartSys : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyPartSysObj());
    }

    private IEnumerator DestroyPartSysObj()


    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
