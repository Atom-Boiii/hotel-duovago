using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;

public class VRSphereTest : MonoBehaviour
{
    private HandPrescence prescence;

    private bool isGrabbed;

    // Start is called before the first frame update
    void Start()
    {
        HandPrescence[] prensences = FindObjectsOfType<HandPrescence>();
        foreach (var item in prensences)
        {
            if(item.type == UnityEngine.XR.InputDeviceCharacteristics.Right)
            {
                prescence = item;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrabbed)
        {
            if (prescence.HasTriggerPressed())
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    public void SetGrabbedState(bool state)
    {
        isGrabbed = state;
    }
}
