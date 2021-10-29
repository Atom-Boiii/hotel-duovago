using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBot : MonoBehaviour
{   
    public void OnFinished()
    {
        GameObject.Find("ElevatorTeleport").GetComponent<ElevatorButton>().enable = true;
    }
}
