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

    private float beingWateredTimer;
    public float maxBeingWateredTimer;
    private float wateredTimer;
    public float maxWateredTimer;
    public float maxGrowthTimer;

    void Start()
    {
        gameObject.GetComponent<Transform>().localScale = minimumSize;
        wateredTimer = maxGrowthTimer;
        maxGrowth = false;
        watered = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(beingWatered == true)
        {
            beingWateredTimer -= Time.deltaTime;
            if(beingWateredTimer <= 0)
            {
                beingWatered = false;
            }
        }

        if(watered == true)
        {
            wateredTimer -= Time.deltaTime;
            if(wateredTimer <= 0)
            {
                watered = false;
                if(maxGrowth == true)
                {
                    maxGrowth = false;
                }
            }
        }

        if(beingWatered == true)
        {
            if(maxGrowth == false)
            {
                gameObject.GetComponent<Transform>().localScale += new Vector3(growthRate * Time.deltaTime, growthRate * Time.deltaTime, growthRate * Time.deltaTime);
                if(gameObject.GetComponent<Transform>().localScale.x >= maxSize.x)
                {
                    maxGrowth = true;
                    gameObject.GetComponent<Transform>().localScale = maxSize;
                }
            }
            if(watered == false)
            {
                    watered = true;
            }
        }
        else if(watered == false && maxShrink == false)
        {
            gameObject.GetComponent<Transform>().localScale -= new Vector3(shrinkRate * Time.deltaTime, shrinkRate * Time.deltaTime, shrinkRate * Time.deltaTime);
            if (gameObject.GetComponent<Transform>().localScale.x <= minimumSize.x)
            {
                maxShrink = true;
                gameObject.GetComponent<Transform>().localScale = minimumSize;
            }
        }

    }

    public void Watering()
    {
        if(beingWatered == false)
        {
            beingWatered = true;
        }

        if (maxGrowth == true)
        {
            wateredTimer = maxGrowthTimer;
        }
        else
        {
            wateredTimer = maxWateredTimer;
        }

        beingWateredTimer = maxBeingWateredTimer;

        if(maxShrink == true)
        {
            maxShrink = false;
        }
    }
}
/* state of decay
 * state of growth
 * state of max decay
 * state of max growth
 * 
 * if grow = max, maxgrowth true, timer till decay, timer turns off max growth
 */