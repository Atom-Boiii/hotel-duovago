using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public Conversation conv;

    public TMPro.TMP_Text id;

    //public string[] names;

    private void Start()
    {
        int number = Random.Range(10, 300);

        conv = gameObject.GetComponent<Conversation>();
        conv.robotName = "Robot #" + number.ToString();
        gameObject.name = conv.robotName;
        id.text = "#" + number.ToString();
    }

    public void StartConversation()
    {
        FindObjectOfType<ConversationManager>().StartConversation(conv);

        
        FindObjectOfType<Computer>().CreateReservation(conv.robotName);
    }
}
