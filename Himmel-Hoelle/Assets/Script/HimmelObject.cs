using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HimmelObject : MonoBehaviour
{
    public SpawnerObject SpawnerObject { get; private set; }

    // Konstruktor, der einen SpawnerObject akzeptiert
    public HimmelObject(SpawnerObject spawnerObject)
    {
        SpawnerObject = spawnerObject;
    }

}
