using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboRandomizer : MonoBehaviour
{
    public bool runFromStart;

    public GameObject robot;

    private int index;

    private RobotMovement rm;

    private void Start()
    {
        if (runFromStart)
        {
            SpawnBot();
        }
    }

    // Start is called before the first frame update
    public void SpawnBot()
    {
        index = 0;

        RobotMovement[] movements = FindObjectsOfType<RobotMovement>();

        foreach (var item in movements)
        {
            if (index == item.checkPointID)
            {
                rm = item;
            }
        }

        GameObject rob = Instantiate(robot, rm.checkPoints[0].position, rm.checkPoints[0].rotation);

        rob.GetComponent<RobotMovementSequence>().robotCheckPoints = index;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
