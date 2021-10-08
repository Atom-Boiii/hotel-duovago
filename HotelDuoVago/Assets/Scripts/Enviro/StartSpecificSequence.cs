using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpecificSequence : MonoBehaviour
{
    public TutorialManager tutorial;
    public bool canSpawn = true;
    public int spawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand" && canSpawn)
        {
            canSpawn = false;
            FindObjectOfType<RoboRandomizer>().SpawnBot(spawn);
            tutorial.DisableTutorial();
        }
    }
}
