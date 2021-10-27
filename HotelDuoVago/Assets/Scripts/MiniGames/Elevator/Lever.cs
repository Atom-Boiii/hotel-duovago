using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Animator anim;
    public Switch switchScript;
    private bool down;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            down = !down;
            anim.SetBool("isDown", down);
        }
    }

    public void IsDown()
    {
        
        switchScript.flipSwitch();
    }
}
