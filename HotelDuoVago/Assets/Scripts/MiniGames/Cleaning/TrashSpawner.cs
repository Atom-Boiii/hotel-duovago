using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class TrashSpawner : MonoBehaviour
{
    public GameObject bottle;
    public GameObject trashObject;

    public Transform[] bottleSpawns;
    public Transform[] trashSpawn;
    public Transform[] stainSpawn;
    public Transform[] floorTrashSpawn;

    public TMP_Text trashText;

    int bottles;
    int trash;
    int stains;
    int floorTrash;

    int bottlesDone = 0;
    int trashDone = 0;

    int totalTrash;

    private void Start()
    {
        bottles = Random.Range(2, bottleSpawns.Length);
        totalTrash += bottles;
        trash = Random.Range(0, trashSpawn.Length);
        totalTrash += trash;
        /*
        stains = Random.Range(0, stainSpawn.Length);
        floorTrash = Random.Range(0, floorTrashSpawn.Length);
        */

        for (int i = 0; i < bottles; i++)
        {
            int r1 = Random.Range(0, bottleSpawns.Length);
            Instantiate(bottle, bottleSpawns[r1].position, bottleSpawns[r1].rotation);
        }

        for (int i = 0; i < trash; i++)
        {
            int r2 = Random.Range(0, trashSpawn.Length);
            Instantiate(trashObject, trashSpawn[r2].position, trashSpawn[r2].rotation);
        }

        trashText.text = "• Bottles: " + bottlesDone + "/" + bottles + "<br>" + "• trash: " + trashDone + "/" + trash + "<br>• Stain: 0/10<br>• Floor Trash: 0/10";
    }
}
