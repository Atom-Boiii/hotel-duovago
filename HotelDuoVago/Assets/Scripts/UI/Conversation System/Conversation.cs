using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Conversation : MonoBehaviour
{
    public string robotName;

    [TextArea(3, 10)]
    public string[] robotDialogueText;
    [TextArea(3, 10)]
    public string[] robotEndQuestDialogueText;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI sentenceText;
    public Canvas canvas;

    public void Start()
    {
        canvas = gameObject.transform.Find("Robot Canvas").GetComponent<Canvas>();
        nameText = canvas.gameObject.transform.Find("Name").GetComponent<TextMeshProUGUI>();
        sentenceText = canvas.gameObject.transform.Find("Sentence").GetComponent<TextMeshProUGUI>();
        canvas.gameObject.SetActive(false);
    }
}
