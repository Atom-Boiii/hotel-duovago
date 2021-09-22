using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovementSequence : MonoBehaviour
{
    public int robotCheckPoints;
    public float rotationSpeed;

    private Transform target;
    public float speed;
    private bool startTalk = false;
    private bool move;

    private int wavepointIndex;

    RobotMovement rm;

    // Start is called before the first frame update
    void Start()
    {
        RobotMovement[] movements = FindObjectsOfType<RobotMovement>();

        foreach (var item in movements)
        {
            if(robotCheckPoints == item.checkPointID)
            {
                rm = item;
            }
        }

        target = rm.checkPoints[0];

        startTalk = false;
        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            {
                GetNextWaypoint();
            }
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * rotationSpeed);
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= rm.checkPoints.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = rm.checkPoints[wavepointIndex];

        //transform.LookAt(target);
    }

    void GetPreviousWaypoint()
    {

    }

    void EndPath()
    {
        if (!startTalk)
        {
            StartCoroutine(StartConversation());
        }

        startTalk = true;
        move = false;
    }

    private IEnumerator StartConversation()
    {
        yield return new WaitForSeconds(1f);

        GetComponent<DistanceToPlayer>().StartConversation();
    }
}
