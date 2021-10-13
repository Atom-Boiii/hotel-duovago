using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpawn : MonoBehaviour
{
    public TutorialManager tutorial;
    public bool canSpawn = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand" && canSpawn)
        {
            canSpawn = false;
            FindObjectOfType<RoboRandomizer>().SpawnBot(Random.Range(0, FindObjectOfType<RoboRandomizer>().robots.Length));
            tutorial.DisableTutorial();
            tutorial.EnableSecondTutorial();
        }
    }
}
