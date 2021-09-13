using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFun : MonoBehaviour
{
    public GameObject fun;

    public void ActiveFun()
    {
        fun.GetComponent<IncreaseFun>().ActivateCoroutine();
    }
}
