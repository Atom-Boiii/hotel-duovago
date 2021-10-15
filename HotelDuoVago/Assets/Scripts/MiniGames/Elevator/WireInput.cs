using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.OpenXR;

public class WireInput : MonoBehaviour
{
    public CheckPlug checkPlug;

    private bool isPlugged, preventCon;

    private Collider otherCol;

    public int color, time;

    //Checks if the Plug is touching the Plug Entrance

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "plug" && preventCon == false)
        {
            other.GetComponent<Rigidbody>().isKinematic = true;

            isPlugged = true;
            otherCol = other;

            Debug.Log("Color " + other.GetComponent<Plug>().color + " has entered Color " + color);

            if (other.GetComponent<Plug>().color == color)
            {
                checkPlug.CorrectPlug();

                Debug.Log("Color " + other.GetComponent<Plug>().color + " is in the Correct Spot");
            }

            StartCoroutine("MakeHandDropPlug", other);
        }
    }

    public IEnumerator MakeHandDropPlug(Collider other)
    {
        other.GetComponent<XRGrabInteractable>().enabled = false;

        yield return new WaitForSeconds(time);

        other.GetComponent<XRGrabInteractable>().enabled = true;
    }

    //Checks if the Plug is being pulled out of the Plug Entrance

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "plug" && preventCon == false)
        {
            isPlugged = false;

            if (other.GetComponent<Plug>().color == color)
            {
                checkPlug.CorrectPlugRemoved();
            }

            Debug.Log("Color " + other.GetComponent<Plug>().color + " has exit Color " + color);

            StartCoroutine("PreventInstantReconnect");
        }
    }

    public IEnumerator PreventInstantReconnect()
    {
        preventCon = true;

        yield return new WaitForSeconds(time);

        preventCon = false;
    }

    //Keeps the Plug inside the Plug Entrance

    private void Update()
    {
        if (isPlugged)
        {
            otherCol.transform.position = transform.position;
            otherCol.transform.rotation = transform.rotation;
        }
    }
}
