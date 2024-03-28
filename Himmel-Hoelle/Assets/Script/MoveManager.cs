using UnityEngine;
using UnityEngine.Serialization;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects; // Array von spawnObjects-Objekten
    private int currentIndex = 0; // Aktueller Index im Array

    public void MoveNextObject()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            currentIndex++; 
            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
            spawnObjects[currentIndex].RightObj();
        }
    }
    
    public void MoveCurrentObjectUp()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            spawnObjects[currentIndex].UpObj(); 

            currentIndex--;

            if (currentIndex < 0)
            {
                currentIndex = spawnObjects.Length - 1;
            }
        }
    }

    public void MoveCurrentObjectDown()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            spawnObjects[currentIndex].DownObj();

            currentIndex++;

            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
        }
    }
}