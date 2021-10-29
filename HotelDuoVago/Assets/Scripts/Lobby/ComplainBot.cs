using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplainBot : MonoBehaviour
{
    public void OnFinished()
    {
        GameObject.Find("HotelRoomButton").GetComponent<RoomElevatorButton>().enable = true;
    }
}
