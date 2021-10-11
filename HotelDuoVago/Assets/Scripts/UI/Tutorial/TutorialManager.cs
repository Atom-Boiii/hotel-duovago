using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorialTwo;

    public void EnableTutorial()
    {
        tutorial.SetActive(true);
    }

    public void DisableTutorial()
    {
        tutorial.SetActive(false);
    }

    public void EnableSecondTutorial()
    {
        tutorialTwo.SetActive(true);
    }

    public void DisableSecondTutorial()
    {
        tutorialTwo.SetActive(false);
    }
}
