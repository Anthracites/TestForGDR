using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0.01f;
    public GameObject CurrentTarget;

    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {

        transform.LookAt(CurrentTarget.transform);
        transform.position = Vector3.MoveTowards(transform.position, CurrentTarget.transform.position, speed);
    }
}
