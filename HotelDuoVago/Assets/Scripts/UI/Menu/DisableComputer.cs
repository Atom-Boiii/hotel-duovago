using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComputer : MonoBehaviour
{
    public GameObject computer;
    public void DisableComp()
    {
        if (computer != null)
        {
            computer.SetActive(false);
        }
    }

    public void EnableComp()
    {
        if (computer != null)
        {
            computer.SetActive(true);
        }
    }
}
