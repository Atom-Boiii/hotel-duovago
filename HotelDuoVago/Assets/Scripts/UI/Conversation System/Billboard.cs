using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform lookAtThis;
    void LateUpdate()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - lookAtThis.position);
    }
}
