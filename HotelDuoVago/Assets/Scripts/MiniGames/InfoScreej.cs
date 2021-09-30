using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoScreej : MonoBehaviour
{

    public TMP_Text nameText;
    public TMP_Text ageText;
    public TMP_Text roomText;
    public TMP_Text stayText;

    public GameObject infoScreen;
    public GameObject reservationScreen;

    public void Setup(string name, string age, string room, string stay)
    {
        infoScreen.SetActive(true);
        reservationScreen.SetActive(false);

        nameText.text = name;
        ageText.text = age;
        roomText.text = room;
        stayText.text = stay;
    }

    public void CloseInfo()
    {
        infoScreen.SetActive(false);
        reservationScreen.SetActive(true);
    }
}
