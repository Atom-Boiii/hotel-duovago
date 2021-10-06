using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour
{
    public int room;

    public void OnClick()
    {
        RentBot[] bots = FindObjectsOfType<RentBot>();

        if(bots != null)
        {
            foreach (var item in bots)
            {
                if (item.isActive)
                {
                    item.SetRoom(room);
                }
            }
        }
    }
}
