using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    private string key;

    public void SetKey(string key)
    {
        this.key = key;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponentInParent<KeyGrabber>().GrabKey(other.gameObject, other.GetComponent<Key>().GetNumber());
    }
}
