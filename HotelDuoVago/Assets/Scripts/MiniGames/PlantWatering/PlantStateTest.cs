using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantStateTest : MonoBehaviour
{
    public void OnTriggerStay(Collider o)
    {
        if(o.gameObject.tag == "Plant")
        {
            o.gameObject.GetComponent<PlantState>().Watering();
        }
    }
}
