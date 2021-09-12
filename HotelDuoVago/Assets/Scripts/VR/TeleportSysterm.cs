using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSysterm : MonoBehaviour
{
    public GameObject teleportInteractor;

    HandPrescence prescence;

    void Start()
    {
        prescence = GetComponent<HandPrescence>();
    }

    // Update is called once per frame
    void Update()
    {
        teleportInteractor.SetActive(prescence.HasPrimaryPressed());
    }
}
