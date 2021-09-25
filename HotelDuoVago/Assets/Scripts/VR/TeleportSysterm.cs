using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSysterm : MonoBehaviour
{
    public GameObject teleportInteractor;

    HandPrescence prescence;

    public bool canTP;

    void Start()
    {
        prescence = GetComponent<HandPrescence>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canTP)
        {
            teleportInteractor.SetActive(prescence.HasPrimaryPressed());
        }
    }
}
