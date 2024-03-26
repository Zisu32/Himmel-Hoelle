using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawner;
    List<GameObject> myChar;

    private void Start()
    {
        this.myChar = new List<GameObject>();
    }

    void Update()
    {
        Vector3 spawnLocation = new Vector3(-1100, 50, 999);

        if (this.transform.position.x >= spawnLocation.x)
        {
            SpawnObject(spawnLocation);
        }
    }

    public void SpawnObject(Vector3 spawnPosition)
    {
        // Only create 5 Objects, not more
        if (this.myChar.Count >= 5) return;

        int index = this.myChar.Count + 1;
        GameObject myCharacter = Instantiate(this.spawner, spawnPosition, Quaternion.identity);
        myCharacter.name = "myCharacter #" + index;
        this.myChar.Add(myCharacter);
    }
}