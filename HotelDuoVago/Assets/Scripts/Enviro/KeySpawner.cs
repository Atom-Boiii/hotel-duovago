using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject key;
    public Transform[] spawn;

    public List<Key> allKeys = new List<Key>();

    public bool isOpen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            if (isOpen)
            {
                int randomState = Random.Range(0, spawn.Length);

                GameObject tempKeyCorrect = Instantiate(key, spawn[randomState].position, spawn[randomState].rotation);

                RobotMovementSequence[] robots = FindObjectsOfType<RobotMovementSequence>();

                foreach (var item in robots)
                {
                    if (item.isActive)
                    {
                        tempKeyCorrect.GetComponent<Key>().Setup(item.roomNumber);
                    }
                }

                allKeys.Add(tempKeyCorrect.GetComponent<Key>());

                for (int i = 0; i < spawn.Length; i++)
                {
                    if(i != randomState)
                    {
                        GameObject tempKey = Instantiate(key, spawn[i].position, spawn[i].rotation);
                        tempKey.GetComponent<Key>().Setup(Random.Range(100, 400).ToString());

                        allKeys.Add(tempKey.GetComponent<Key>());
                    }
                }
            }
        }
    }
}
