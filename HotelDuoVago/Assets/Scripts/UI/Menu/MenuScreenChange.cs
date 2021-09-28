using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreenChange : MonoBehaviour
{
    //Menu Buttons

    public GameObject uiInteractor;
    public GameObject teleportRay;

    public void StartButton()
    {
        //uiInteractor.SetActive(false);
        teleportRay.SetActive(true);
        FindObjectOfType<TeleportSysterm>().canTP = true;
    }

    public void ReturnToMenuButton()
    {
        uiInteractor.SetActive(true);
        teleportRay.SetActive(false);
    }

    public void Pause()
    {
        uiInteractor.SetActive(true);
        teleportRay.SetActive(false);
    }

    public void ExitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
