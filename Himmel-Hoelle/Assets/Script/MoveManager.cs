using UnityEngine;
using UnityEngine.Serialization;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects; // Array von spawnObjects-Objekten
    public int currentIndex = 0; // Aktueller Index im Array
    public ChangeText changeText; // Reference to the ChangeText component
    public PlayerHealth playerHealth;
    
    private void Start()
    {
        if(spawnObjects.Length > 0)
        {
            spawnObjects[0].StartMovingRightAutomatically();
        }
        playerHealth = FindObjectOfType<PlayerHealth>();

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
            if(currentIndex == 1){
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
            spawnObjects[currentIndex].DownObj();

            currentIndex++;

            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
        }
    }
    // Method to change the text
    public void ChangePodestText(string newText)
    {
        changeText.podestText.text = newText;
    }
}