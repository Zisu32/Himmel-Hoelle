using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public SpawnerObject[] spawnObjects;
    public int currentIndex = 0;
    public int lastMovedIndex = 0;
    public ChangeText changeText;
    public PlayerHealth playerHealth;
    public AudioSource rollSound;
    public float damage = 30f;
    public float heal = 10f;

    private void Start()
    {
        if (spawnObjects.Length > 0)
        {
            spawnObjects[0].StartMovingRightAutomatically();
            rollSound.Play();
        }
        playerHealth = FindFirstObjectByType<PlayerHealth>();
    }

    public void MoveNextObject()
    {
        lastMovedIndex = currentIndex;
        currentIndex++;

        if (currentIndex >= spawnObjects.Length)
        {
            currentIndex = 0;
        }
        spawnObjects[currentIndex].RightObj();
    }

    public void MoveCurrentObjectUp()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            if (spawnObjects[currentIndex].isEvil)
            {
                playerHealth.GameOver();
            }
            
            playerHealth.Heal(heal);
            spawnObjects[currentIndex].UpObj();

            lastMovedIndex = currentIndex;
            currentIndex = lastMovedIndex + 1;

            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
            spawnObjects[currentIndex].RightObj();
        }
    }

    public void MoveCurrentObjectDown()
    {
        if (currentIndex >= 0 && currentIndex < spawnObjects.Length)
        {
            if (spawnObjects[currentIndex].isGood)
            {
                playerHealth.TakeDamage(damage);
            }
            if (spawnObjects[currentIndex].isEvil)
            {
                playerHealth.Heal(heal);
            }

            spawnObjects[currentIndex].DownObj();

            lastMovedIndex = currentIndex;
            currentIndex = lastMovedIndex + 1;

            if (currentIndex >= spawnObjects.Length)
            {
                currentIndex = 0;
            }
            spawnObjects[currentIndex].RightObj();
        }
    }

    public void ObjectMovementCompleted()
    {
        bool allObjectsMoved = true;
        foreach (SpawnerObject spawnObject in spawnObjects)
        {
            if (!spawnObject.isHimmel && !spawnObject.isHoelle)
            {
                allObjectsMoved = false;
                break;
            }
        }

        if (allObjectsMoved)
        {
            playerHealth.ShowEndPanel();
        }
    }
}
