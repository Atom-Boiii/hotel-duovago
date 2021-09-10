using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseFun : MonoBehaviour
{
    public GameObject increaseFun;
    public GameObject glitch;
    public float glitchTime;
    public void ActivateCoroutine()
    {
        StartCoroutine(Glitch());
    }

    IEnumerator Glitch()
    {
        increaseFun.SetActive(false);
        glitch.SetActive(true);
        yield return new WaitForSeconds(glitchTime);
        glitch.SetActive(false);
    }
}
