using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold;
    public bool pourCheck;
    public bool isPouring;

    public GameObject pourParticle;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pourCheck = CalculatePourAngle() < pourThreshold;
        //print(CalculatePourAngle());

        if(isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();
            }
            else
            {
                EndPour();
            }
        }
    }

    public void StartPour()
    {
        pourParticle.SetActive(true);
    }

    public void EndPour()
    {
        pourParticle.SetActive(false);
    }

    private float CalculatePourAngle()
    {
        return transform.up.y * Mathf.Rad2Deg;
    }


}
