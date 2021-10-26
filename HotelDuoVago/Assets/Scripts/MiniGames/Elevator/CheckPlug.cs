using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlug : MonoBehaviour
{
    public int plugCount, plugMax, plugInt;
    public GameObject doorSwitch;

    public void Start()
    {
        Cable[] cableCount = FindObjectsOfType(typeof(Cable)) as Cable[];

        foreach (Cable cable in cableCount)
        {
            plugMax += plugInt;
        }
    }

    public void CheckPlugSpot()
    {
        if (plugCount == plugMax)
        {
            doorSwitch.GetComponent<Switch>().minigameWon = true;

            Debug.Log("Elevator Minigame Won");
        }
    }

    public void CorrectPlug()
    {
        plugCount += plugInt;

        //Debug.Log("Correct Plug");

        CheckPlugSpot();
    }

    public void CorrectPlugRemoved()
    {
        plugCount -= plugInt;

        //Debug.Log("Correct Plug Removed");
    }
}
