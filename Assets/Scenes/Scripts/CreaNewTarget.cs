using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaNewTarget : MonoBehaviour
{
    private Vector3 SpawnPosition;
    private GameObject inst_obj;
    public GameObject Target;

    void Start()
    {
       SpawnPosition = new Vector3(-(gameObject.transform.position.x), (gameObject.transform.position.y), (gameObject.transform.position.z));
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "EnemyBody") 
        {
            inst_obj = Instantiate(Target, SpawnPosition, Quaternion.identity) as GameObject;
            inst_obj.name = "Target";
            other.GetComponent<EnemyMove>().CurrentTarget = inst_obj;
            Destroy(gameObject);
        }
        else
        {

        }
    }
}
