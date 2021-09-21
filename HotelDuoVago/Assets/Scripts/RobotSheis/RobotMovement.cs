using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    public int checkPointID;

    public Transform[] checkPoints;

    private void Awake()
    {
        checkPoints = new Transform[transform.childCount];

        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i] = transform.GetChild(i);
        }
    }
}
