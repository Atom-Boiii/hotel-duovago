using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public Conversation conv;

    public void StartConversation()
    {
        conv = gameObject.GetComponent<Conversation>();
        FindObjectOfType<ConversationManager>().StartConversation(conv);
    }
}
