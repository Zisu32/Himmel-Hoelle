using UnityEngine;
using UnityEngine.Serialization;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects; // Array von spawnObjects-Objekten
    public HimmelObject[] himmelObjects;
    private int currentIndex = 0; // Aktueller Index im Array
    
    // Methode zum Bewegen des nächsten Objekts
    public void MoveNextObject()
    {
        // Überprüfe, ob der currentIndex innerhalb des gültigen Bereichs liegt
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            // Bewege das aktuelle Objekt nach rechts
            spawnObjects[currentIndex].RightMovement();

            // Inkrementiere den Index für das nächste Objekt
            currentIndex++;

            // Überprüfe, ob der Index den maximalen Index im Array nicht überschritten hat
            if (currentIndex >= spawnObjects.Length)
            {
                // Setze den Index auf den Anfang des Arrays zurück
                currentIndex = 0;
            }
        }
    }
    
    // Methode zum Bewegen des aktuellen Objekts nach oben und aus dem Array löschen
    public void MoveCurrentObjectUpAndRemove()
    {
        // Überprüfe, ob der currentIndex innerhalb des gültigen Bereichs liegt
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            // Füge das aktuelle Objekt zum himmelObjects-Array hinzu
            AddToHimmelObjects(spawnObjects[currentIndex]);

            // Entferne das Objekt aus dem spawnObjects-Array
            RemoveFromSpawnObjects(currentIndex);
        }
    }

    // Methode zum Bewegen des aktuellen Objekts nach oben
    public void MoveCurrentObjectUp()
    {
        // Überprüfe, ob der currentIndex innerhalb des gültigen Bereichs liegt
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            // Bewege das aktuelle Objekt nach oben
            spawnObjects[currentIndex].UpObj();

            // Zerstöre das aktuelle Objekt
            // Destroy(moveObjects[currentIndex].gameObject);
        }
    }

    // Methode zum Bewegen des aktuellen Objekts nach unten
    public void MoveCurrentObjectDown()
    {
        // Überprüfe, ob der currentIndex innerhalb des gültigen Bereichs liegt
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            // Bewege das aktuelle Objekt nach unten
            spawnObjects[currentIndex].DownObj();
        }
    }
    // Methode zum Hinzufügen eines Objekts zum himmelObjects-Array
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

    // Methode zum Entfernen eines Objekts aus dem spawnObjects-Array
    private void RemoveFromSpawnObjects(int index)
    {
        // Verschiebe alle Objekte ab dem zu löschenden Index eine Position nach vorne
        for (int i = index; i < spawnObjects.Length - 1; i++)
        {
            spawnObjects[i] = spawnObjects[i + 1];
        }

        // Reduziere die Länge des Arrays um 1, um das letzte Element zu entfernen
        System.Array.Resize(ref spawnObjects, spawnObjects.Length - 1);

        // Setze den Index auf den Anfang des Arrays zurück
        currentIndex = 0;
    }
}