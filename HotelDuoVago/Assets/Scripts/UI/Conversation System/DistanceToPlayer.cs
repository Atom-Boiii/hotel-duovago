using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public Conversation conv;

    public string[] names;

    private void Start()
    {
        conv = gameObject.GetComponent<Conversation>();
        conv.robotName = names[Random.Range(0, names.Length)];
        gameObject.name = conv.robotName;
    }

    public void StartConversation()
    {
        FindObjectOfType<ConversationManager>().StartConversation(conv);

        
        FindObjectOfType<Computer>().CreateReservation(conv.robotName);
    }
}
