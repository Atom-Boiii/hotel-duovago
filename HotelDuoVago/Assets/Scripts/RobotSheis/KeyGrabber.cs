using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrabber : MonoBehaviour
{
    public void Init()
    {
        GetComponent<Animator>().SetBool("GrabState", true);
    }

    // Start is called before the first frame update
    public void GrabKey(GameObject other, string number)
    {
        if(number == GetComponent<RobotMovementSequence>().roomNumber)
        {
            if (other.tag == "key")
            {
                Destroy(other.gameObject);

                // Start ending convo
                StartCoroutine(KeyGrabbed());
            }
        }
        else
        {
            Destroy(other.gameObject);
            FindObjectOfType<ConversationManager>().SetupFailConversation();
            Debug.Log("Wrong key!");
        }
    }

    private IEnumerator KeyGrabbed()
    {
        GetComponent<RobotMovementSequence>().isActive = false;

        yield return new WaitForSeconds(1f);

        FindObjectOfType<ConversationManager>().SetupQuestEndConversation();

        yield return new WaitForSeconds(1f);

        GetComponent<RobotMovementSequence>().StartMovingStairs();

        yield return new WaitForSeconds(1f);

        FindObjectOfType<StartSpawn>().canSpawn = true;

    }
}
