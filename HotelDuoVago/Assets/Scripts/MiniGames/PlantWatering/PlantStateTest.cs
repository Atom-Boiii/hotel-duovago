using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantStateTest : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Plant")
        {
            other.gameObject.GetComponent<PlantState>().Watering();
        }
    }
}
