using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSizeChange : MonoBehaviour
{
    public Vector3 scaleChange;
    public void MouseHoverOn()
    {
        transform.localScale += scaleChange;
    }

    public void MouseHoverOff()
    {
        transform.localScale -= scaleChange;
    }
}
