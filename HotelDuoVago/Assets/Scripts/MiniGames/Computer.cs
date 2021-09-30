using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public GameObject desktop;

    public List<string> reservations = new List<string>();

    public GameObject reservationItem;

    public Transform content;

    public GameObject reservationTab;

    public void OpenReservation()
    {
        desktop.SetActive(false);
        reservationTab.SetActive(true);
    }

    public void BackToDesktop()
    {
        desktop.SetActive(true);
        reservationTab.SetActive(false);
    }

    public void CreateReservation(string name)
    {
        GameObject refrence = Instantiate(reservationItem, content);

        ReservationItem ri = refrence.GetComponent<ReservationItem>();

        int age = Random.Range(20, 70);

        string room = GameObject.Find(name).GetComponent<RobotMovementSequence>().roomNumber;

        int stay = Random.Range(5, 20);
            
        ri.Setup(name, age.ToString(), room, stay.ToString());
    }
}
