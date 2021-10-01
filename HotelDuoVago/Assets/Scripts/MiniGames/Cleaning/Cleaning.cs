using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    public float minusAlpha;

    public bool hoover;
    public bool rag;
    public bool trashBag;

    public string hooverToCleanTag;
    public string ragToCleanTag;
    public string trashToCleanTag;

    public void OnTriggerStay(Collider o)
    {
        if(o.gameObject.tag == hooverToCleanTag && hoover == true)
        {
            o.gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, minusAlpha * Time.deltaTime);
            if (o.gameObject.GetComponent<Renderer>().material.color.a <= 0)
            {
                Destroy(o.gameObject);
                //add progress to task
            }
        }
    }

    public void OnTriggerEnter(Collider o)
    {
        if (o.gameObject.tag == ragToCleanTag && rag == true)
        {
            o.gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, minusAlpha);
            if (o.gameObject.GetComponent<Renderer>().material.color.a <= 0)
            {
                Destroy(o.gameObject);
                //add progress to task
            }
        }

        if (o.gameObject.tag == trashToCleanTag && trashBag == true)
        {
            o.gameObject.GetComponent<CleaningTrash>().EnteredTrashCan(minusAlpha);
            //add progress to task
        }
    }
}
//wait to fail