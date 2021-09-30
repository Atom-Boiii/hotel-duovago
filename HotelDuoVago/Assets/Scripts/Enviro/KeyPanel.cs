using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPanel : MonoBehaviour
{
    public bool isOpen;

    public Transform target;
    public Transform doorPanel;

    private Vector3 startPos;

    private void Start()
    {
        isOpen = false;

        startPos = doorPanel.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            isOpen = true;
            FindObjectOfType<KeySpawner>().isOpen = true;

            StartCoroutine(ClosePanel());
        }
    }

    private void Update()
    {
        if (isOpen)
        {
            doorPanel.transform.position = Vector3.Slerp(doorPanel.transform.position, target.position, Time.deltaTime / 3f);
        }
        else
        {
            doorPanel.transform.position = Vector3.Slerp(doorPanel.position, startPos, Time.deltaTime / 3f);
        }
    }
    private IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(15f);

        isOpen = false;
    }

}
