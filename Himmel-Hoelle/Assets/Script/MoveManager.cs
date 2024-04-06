using UnityEngine;
using UnityEngine.Serialization;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects; // Array von spawnObjects-Objekten
    public int currentIndex = 0; // Aktueller Index im Array
    public ChangeText changeText; // Reference to the ChangeText component
    public PlayerHealth playerHealth;
    public AudioSource rollSound;
    public float damage = 30f;
    private void Start()
    {
        if(spawnObjects.Length > 0)
        {
            spawnObjects[0].StartMovingRightAutomatically();
            rollSound.Play();
            
        }
        playerHealth = FindFirstObjectByType<PlayerHealth>();

    }
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
            if(spawnObjects[currentIndex].isEvil)
            {
                playerHealth.GameOver();
            }
            
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
            if(spawnObjects[currentIndex].isGood)
            {
                playerHealth.TakeDamage(damage);
            }
            
            spawnObjects[currentIndex].DownObj();

            currentIndex++;

            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
        }
    }
}