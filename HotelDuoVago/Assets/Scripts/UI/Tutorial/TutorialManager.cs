using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorial;

    public void EnableTutorial()
    {
        tutorial.SetActive(true);
    }

    public void DisableTutorial()
    {
        tutorial.SetActive(false);
    }
}
