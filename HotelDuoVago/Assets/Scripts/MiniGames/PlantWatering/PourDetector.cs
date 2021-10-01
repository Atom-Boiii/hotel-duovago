using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold;
    private int pourDegree;
    public bool pourCheck;
    public bool isPouring;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pourDegree < pourThreshold)
        {
            pourCheck = true;
        }
        else
        {
            pourCheck = false;
        }

        if(isPouring != pourCheck)
        {

        }
    }

    public void CalculatePourAngle()
    {
        return;
    }
}
