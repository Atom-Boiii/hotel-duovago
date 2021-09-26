using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject key;
    public Transform spawn;

    public bool isOpen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            Instantiate(key, spawn.position, spawn.rotation);
        }
    }
}
