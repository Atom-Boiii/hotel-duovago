using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBell : MonoBehaviour
{
    public GameObject fadeOut;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            fadeOut.SetActive(true);
        }
    }
}
