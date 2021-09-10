using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFun : MonoBehaviour
{
    public GameObject increaseFun;
    public void MouseHoverOn()
    {
        increaseFun.SetActive(false);
    }
}
