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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider o)
    {
        print("1");
        if(o.gameObject.tag == hooverToCleanTag && hoover == true)
        {
            o.gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, minusAlpha);
            if(o.gameObject.GetComponent<Renderer>().material.color.a <= 0)
            {
                Destroy(o.gameObject);
            }
            //remove stuff??? slowly or instant???
            //add progress to task
        }

        if (o.gameObject.tag == ragToCleanTag && rag == true)
        {
            print("2");
            o.gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, minusAlpha);
            if (o.gameObject.GetComponent<Renderer>().material.color.a <= 0)
            {
                print("3");
                Destroy(o.gameObject);
            }
            //remove stuff??? slowly or instant???
            //add progress to task
        }

        if (o.gameObject.tag == trashToCleanTag && trashBag == true)
        {
            o.gameObject.GetComponent<CleaningTrash>().EnteredTrashCan(minusAlpha);
            //remove stuff??? after letting go in trashbag/can
            //add progress to task
        }
    }

    public void OnTrashCanEnter(GameObject garbage)
    {

    }
}
//wait to fail