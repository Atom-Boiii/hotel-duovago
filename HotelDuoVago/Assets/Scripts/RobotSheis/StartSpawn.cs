using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour
{
    public bool canSpawn = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand" && canSpawn)
        {
            canSpawn = false;
            FindObjectOfType<RoboRandomizer>().SpawnBot();
        }
    }
}
