using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{
    public GameObject scene;
    public bool enable;

    private void OnTriggerEnter(Collider other)
    {
        if (enable)
        {
            if(other.tag == "Hand")
            {
                scene.SetActive(true);
            }
        }
    }

}
