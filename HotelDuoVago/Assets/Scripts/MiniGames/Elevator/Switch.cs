using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool SwitchFlip, minigameWon;
    public GameObject leftDoor, rightDoor;
    public GameObject testWin, testDoor;

    public void flipSwitch()
    {
        SwitchFlip = !SwitchFlip;
        leftDoor.GetComponent<Animator>().SetBool("ToggleDoor", SwitchFlip);
        rightDoor.GetComponent<Animator>().SetBool("ToggleDoor", SwitchFlip);

        if (SwitchFlip == false && minigameWon)
        {
            testDoor.SetActive(false);
            testWin.SetActive(true);
            Debug.Log("You finished the Minigame");
        }
    }
}
