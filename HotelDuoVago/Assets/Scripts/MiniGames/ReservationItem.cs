using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReservationItem : MonoBehaviour
{
    public TMP_Text nameText;

    string resName, age, room, stay;


    public void Setup(string name, string age, string room, string stay)
    {
        nameText.text = name;

        resName = name;
        this.age = age;
        this.room = room;
        this.stay = stay;
    }

    public void OnPress()
    {
        FindObjectOfType<InfoScreej>().Setup(resName, age, room, stay);
    }
}
