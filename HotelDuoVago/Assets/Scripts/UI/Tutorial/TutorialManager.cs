using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorialTwo;
    public GameObject tutorialThree;
    private bool hasActivated, hasActivatedTwo;

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
        if (hasActivated == false)
        {
            tutorialTwo.SetActive(true);
            hasActivated = true;
        }
    }

    public void DisableSecondTutorial()
    {
        tutorialTwo.SetActive(false);
    }

    public void EnableThirdTutorial()
    {
        if (hasActivatedTwo == false)
        {
            tutorialThree.SetActive(true);
            hasActivated = true;
        }
    }

    public void DisableThirdTutorial()
    {
        tutorialThree.SetActive(false);
    }
}
