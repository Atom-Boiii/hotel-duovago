using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScreenGenerator : MonoBehaviour
{
    public GameObject bookingItem;
    public Transform roomHolder;

    private int roomAmount;
    private int roomNumber;

    private void Start()
    {
        OnPress();
    }

    public void OnPress()
    {
        roomAmount = Random.Range(0, 33);

        roomNumber = Random.Range(100, 400);

        for (int i = 0; i < roomAmount; i++)
        {
            GameObject temp = Instantiate(bookingItem, roomHolder);
            temp.GetComponentInChildren<TMPro.TMP_Text>().text = roomNumber.ToString();
            roomNumber++;

            int random = Random.Range(0, 2);

            if(random == 0)
            {
                temp.GetComponent<UnityEngine.UI.Button>().interactable = false;
            }else if(random == 1)
            {
                temp.GetComponent<UnityEngine.UI.Button>().interactable = true;
            }

        }
    }
}
