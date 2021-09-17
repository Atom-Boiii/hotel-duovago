using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public PlayerLocation player;
    public Conversation conv;

    public float distanceMin;
    public float distance;

    public bool hasStartedTalking;

    public void Update()
    {
        if (hasStartedTalking)
        {
            return;
        }
        /*
        distance = Vector3.Distance(player.player, transform.position);
        if (distance < distanceMin)
        {
            StartConversation();
        }
        */
    }

    public void StartConversation()
    {
        hasStartedTalking = true;
        conv = gameObject.GetComponent<Conversation>();
        FindObjectOfType<ConversationManager>().StartConversation(conv);
    }
}
