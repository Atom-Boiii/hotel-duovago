using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform lookAtThis;
    public GameObject findRig;
    public string vrRigName;

    public void Start()
    {
        findRig = GameObject.Find(vrRigName);
        lookAtThis = findRig.transform;
    }
    void LateUpdate()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - lookAtThis.position);
    }
}
