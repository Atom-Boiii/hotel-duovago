using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : MonoBehaviour
{
    public void Init()
    {
        GetComponent<Animator>().SetBool("GrabState", true);
    }

    // Start is called before the first frame update
    public void GrabKey(GameObject other)
    {
        if (other.tag == "key")
        {
            Destroy(other.gameObject);

            // Start ending convo
            StartCoroutine(KeyGrabbed());
        }
    }

    private IEnumerator KeyGrabbed()
    {
        yield return new WaitForSeconds(1f);
    }
}
