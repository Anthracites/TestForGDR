using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool IsTaked = false;

    private void OnTriggerEnter(Collider other)
    {


        if (other.name == "Pers")
        {
            other.GetComponent<PersStats>().IsKeyTaked = true;
            Destroy(gameObject);

        }
    }
}