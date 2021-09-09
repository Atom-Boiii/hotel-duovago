using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPrescence : MonoBehaviour
{
    public InputDeviceCharacteristics type;

    private InputDevice targetDevice;

    private bool rightTrigger, rightGrip;

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

        rightTrigger = triggerPressed;
        rightGrip = gripPressed;

    }

    public bool RightGripPressed()
    {
        return rightGrip;
    }

    public bool RightTriggerPressed()
    {
        return rightTrigger;
    }
}
