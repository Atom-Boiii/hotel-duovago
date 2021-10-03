using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireInput : MonoBehaviour
{
    private bool isPlugged;

    private Collider otherCol;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "plug")
        {
            other.GetComponent<Rigidbody>().isKinematic = true;

            isPlugged = true;
            otherCol = other;
        }
    }

    private void Update()
    {
        if (isPlugged)
        {
            otherCol.transform.position = transform.position;
            otherCol.transform.rotation = transform.rotation;
        }
    }
}
