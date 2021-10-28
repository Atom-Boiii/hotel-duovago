using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrashSpawner : MonoBehaviour
{
    public GameObject bottle;
    public GameObject trashObject;
    public GameObject stain;
    public GameObject floorStain;

    public Slider progress;

    public Transform[] bottleSpawns;
    public Transform[] trashSpawn;
    public Transform[] stainSpawn;
    public Transform[] floorTrashSpawn;

    public TMP_Text trashText;

    int bottles;
    int trash;
    int stains;
    int floorTrash;
    int plant;

    int bottlesDone = 0;
    int trashDone = 0;
    int stainDone = 0;
    int floorTrashDone = 0;
    int plantDone = 0;

    int totalTrash;
    int totalDone;

    int previousStain;
    int previousFloor;

    private void Start()
    {
        bottles = Random.Range(2, bottleSpawns.Length);
        trash = Random.Range(2, trashSpawn.Length);
        stains = Random.Range(2, stainSpawn.Length);
        floorTrash = Random.Range(2, floorTrashSpawn.Length);
        plant = 2;
        
        totalTrash += bottles;
        totalTrash += trash;
        totalTrash += stains;
        totalTrash += floorTrash;
        totalTrash += plant;

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

        for (int i = 0; i < stains; i++)
        {
            int r3 = Random.Range(0, stainSpawn.Length);
            Instantiate(stain, stainSpawn[r3].position, stainSpawn[r3].rotation);
        }

        for (int i = 0; i < floorTrash; i++)
        {
            int r4 = Random.Range(0, floorTrashSpawn.Length);
            if(r4 != previousFloor)
            {
                previousFloor = r4;
                Instantiate(floorStain, floorTrashSpawn[r4].position, floorTrashSpawn[r4].rotation);
            }
            else
            {
                i--;
            }
        }

        trashText.text = "• Bottles: " + bottlesDone + "/" + bottles + "<br>" + "• trash: " + trashDone + "/" + trash + "<br>• Stain: " + stainDone + "/" + stains + "<br>• Floor Trash: " + floorTrashDone + "/" + floorTrash + "<br>• Plants: " + plantDone + "/" + plant;
        progress.maxValue = totalTrash;
    }

    public void Clean(string type)
    {
        if (type == "Trash")
        {
            trashDone++;
            progress.value++;
        }
        else if (type == "Stain")
        {
            stainDone++;
            progress.value++;
        }
        else if(type == "Bottle")
        {
            bottlesDone++;
            progress.value++;
        }
        else if(type == "FloorStain")
        {
            floorTrashDone++;
            progress.value++;
        }
        else if(type == "Plant")
        {
            plantDone++;
            progress.value++;
        }

        totalDone++;

        trashText.text = "• Bottles: " + bottlesDone + "/" + bottles + "<br>" + "• trash: " + trashDone + "/" + trash + "<br>• Stain: " + stainDone + "/" + stains + "<br>• Floor Trash: " + floorTrashDone + "/" + floorTrash + "<br>• Plants: " + plantDone + "/" + plant;
        
        if(totalTrash == totalDone)
        {
            trashText.text = " Everything is finished.<br> Head back to the lobby!";
        }
    }
}
