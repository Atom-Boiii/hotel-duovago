using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform lookAtThis;
    public Vector3 offset;

    public void Start()
    {
        lookAtThis = Camera.main.transform;
    }
    void LateUpdate()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - lookAtThis.position + offset);
    }
}
