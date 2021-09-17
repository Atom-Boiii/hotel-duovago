using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovementSequence : MonoBehaviour
{
    private Transform target;
    public float speed;

    private int wavepointIndex;

    // Start is called before the first frame update
    void Start()
    {
        target = RobotMovement.checkPoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= RobotMovement.checkPoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = RobotMovement.checkPoints[wavepointIndex];
    }

    void EndPath()
    {
        print("call");
    }
}
