using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    public Vector3 player;

    public void Start()
    {
        SetPlayerPosition();
    }

    public void SetPlayerPosition()
    {
        player = gameObject.transform.position;
    }
}
