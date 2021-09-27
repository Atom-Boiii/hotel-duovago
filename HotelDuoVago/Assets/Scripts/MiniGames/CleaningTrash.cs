using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningTrash : MonoBehaviour
{
    public bool trashCanEntered;
    public float minusAlpha;

    void Update()
    {
        if(trashCanEntered == true)
        {
            gameObject.GetComponent<Renderer>().material.color -= new Color(0, 0, 0, minusAlpha * Time.deltaTime);
            if (gameObject.GetComponent<Renderer>().material.color.a <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void EnteredTrashCan(float minusAlpha1)
    {
        minusAlpha = minusAlpha1 * 3;
        trashCanEntered = true;
    }
}
