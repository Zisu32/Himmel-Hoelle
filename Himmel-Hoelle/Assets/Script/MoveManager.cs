using UnityEngine;
using UnityEngine.Serialization;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects; // Array von spawnObjects-Objekten
    public HimmelObject[] himmelObjects;
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
            spawnObjects[currentIndex].RightMovement();
        }
    }
    
    public void MoveCurrentObjectUpAndRemove()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            AddToHimmelObjects(spawnObjects[currentIndex]);

            RemoveFromSpawnObjects(currentIndex);
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
  
    private void AddToHimmelObjects(SpawnerObject obj)
    {
        // Erstelle ein neues Array mit einer zusätzlichen Position für das neue Objekt
        HimmelObject[] newHimmelObjects = new HimmelObject[himmelObjects.Length + 1];

        // Kopiere die vorhandenen Objekte in das neue Array
        for (int i = 0; i < himmelObjects.Length; i++)
        {
            newHimmelObjects[i] = himmelObjects[i];
        }

        // Füge das neue Objekt zum Ende des Arrays hinzu
        newHimmelObjects[himmelObjects.Length] = new HimmelObject(obj);

        // Weise das neue Array dem ursprünglichen Array zu
        himmelObjects = newHimmelObjects;
    }

    private void RemoveFromSpawnObjects(int index)
    {
        // Verschiebe alle Objekte ab dem zu löschenden Index eine Position nach vorne
        for (int i = index; i < spawnObjects.Length - 1; i++)
        {
            spawnObjects[i] = spawnObjects[i + 1];
        }

        // Reduziere die Länge des Arrays um 1, um das letzte Element zu entfernen
        System.Array.Resize(ref spawnObjects, spawnObjects.Length - 1);

        currentIndex = 0;
    }
}