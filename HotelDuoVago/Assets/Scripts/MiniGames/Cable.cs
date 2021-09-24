using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public Transform plug;
    public Vector3 offset;

    public LineRenderer line;

    private void Update()
    {
        line.SetPosition(0, transform.position - offset);
        line.SetPosition(1, plug.position);  
    }
}
