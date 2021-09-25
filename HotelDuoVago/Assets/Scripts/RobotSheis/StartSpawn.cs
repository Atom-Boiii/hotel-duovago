using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            FindObjectOfType<RoboRandomizer>().SpawnBot();
        }
    }
}
