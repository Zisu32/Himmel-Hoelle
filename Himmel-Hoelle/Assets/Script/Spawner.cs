using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject MySphere;

    public void SpawnSphere()
    {
        Instantiate(MySphere,Vector3.zero, Quaternion.identity);
    }
}
