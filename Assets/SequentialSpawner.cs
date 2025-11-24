using UnityEngine;
using System.Collections;

public class SequentialSpawner : MonoBehaviour
{
    [Header("Objects To Spawn (Prefabs)")]
    public GameObject[] objectsToSpawn;

    [Header("Spawn Points")]
    public Transform[] spawnPoints; // 5 positions

    private int index = 0;
    private GameObject currentObject;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // Spawn the object
            currentObject = Instantiate(objectsToSpawn[index],
                                       spawnPoints[index].position,
                                       spawnPoints[index].rotation);

            // Wait until player destroys it
            while (currentObject != null)
            {
                yield return null; // wait next frame
            }

            // Move to next
            index++;

            // Loop back
            if (index >= objectsToSpawn.Length)
                index = 0;
        }
    }
}
