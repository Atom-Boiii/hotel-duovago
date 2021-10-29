using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomElevatorButton : MonoBehaviour
{
    public GameObject scene;
    public bool enable;

    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        if (enable)
        {
            if(other.tag == "Hand")
            {
                source.Play();
                scene.SetActive(true);
            }
        }
    }

}
