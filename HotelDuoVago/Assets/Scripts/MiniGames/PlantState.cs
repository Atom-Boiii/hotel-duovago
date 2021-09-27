using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantState : MonoBehaviour
{
    public float shrinkRate;
    public float growthRate;

    public bool watered;
    public bool beingWatered;

    private bool maxGrowth;
    private bool maxShrink;

    public Vector3 maxSize;
    public Vector3 minimumSize;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(beingWatered == true)
        {
            if(maxGrowth == false)
            {
                gameObject.GetComponent<Transform>().localScale += new Vector3(growthRate * Time.deltaTime, growthRate * Time.deltaTime, growthRate * Time.deltaTime);
                if(gameObject.GetComponent<Transform>().localScale.x >= maxSize.x)
                {

                }
            }

        }
        else if(watered == false)
        {
            gameObject.GetComponent<Transform>().localScale -= new Vector3(shrinkRate * Time.deltaTime, shrinkRate * Time.deltaTime, shrinkRate * Time.deltaTime);
        }

    }
}
/* state of decay
 * state of growth
 * state of max decay
 * state of max growth
 */