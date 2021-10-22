using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFun : MonoBehaviour
{
    public GameObject increaseFun;
    public GameObject glitch;
    public void ActivateFun()
    {
        increaseFun.SetActive(false);
        glitch.SetActive(true);
    }
}
