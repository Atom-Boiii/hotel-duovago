using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RentBot : MonoBehaviour
{
    public int room;

    public bool isActive;

    private void Start()
    {
        isActive = true;
    }

    public void SetRoom(int room)
    {
        if(room == this.room)
        {
            FindObjectOfType<ConversationManager>().SetupQuestEndConversation();

            GetComponent<RobotMovementSequence>().StartMovingStairs();
            isActive = false;
        }
        else
        {
            FindObjectOfType<ConversationManager>().SetupFailConversation();
        }
    }
}
