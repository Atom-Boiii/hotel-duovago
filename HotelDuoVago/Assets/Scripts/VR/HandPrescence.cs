using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPrescence : MonoBehaviour
{
    public InputDeviceCharacteristics type;

    private InputDevice targetDevice;

    private bool rightTrigger, hasGripPressed, hasPrimaryPressed;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = type | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool triggerPressed);
        targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripPressed);
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryPressed);

        rightTrigger = triggerPressed;
        hasGripPressed = gripPressed;
        hasPrimaryPressed = primaryPressed;
    }

    public bool HasGripPressed()
    {
        return hasGripPressed;
    }

    public bool HasTriggerPressed()
    {
        return rightTrigger;
    }

    public bool HasPrimaryPressed()
    {
        return hasPrimaryPressed;
    }
}
