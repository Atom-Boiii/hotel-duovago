using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFun : MonoBehaviour
{
    public GameObject fun;

    public void MouseHoverOn()
    {
        fun.GetComponent<IncreaseFun>().ActivateCoroutine();
    }
}
