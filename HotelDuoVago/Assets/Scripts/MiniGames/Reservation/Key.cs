using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public TMP_Text numberText;

    private string number;

    public void Setup(string number)
    {
        this.number = number;
        numberText.text = number;
    }
    public string GetNumber()
    {
        return number;
    }

    public void OnGrab()
    {
        KeySpawner ks = FindObjectOfType<KeySpawner>();

        foreach (var item in ks.allKeys)
        {
            if(item != this)
            {
                Destroy(item.gameObject);
            }
        }

        ks.allKeys.Clear();
    }
}
