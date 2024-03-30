using NUnit.Framework.Constraints;
using UnityEngine;

public class SpawnerObject : MonoBehaviour
{
    public float moveSpeed = 500f; // Geschwindigkeit der Bewegung
    public float upSpeed = 500f;
    public float downSpeed = 500f;
    private float stopXCoordinate = 0f; // X-Koordinate zum Stoppen
    private float stopHimmel = 1000f; // Y-Koordinate zum Stoppen im Himmel
    private float stopHoelle = -1000f; // Y-Koordinate zum Stoppen in Hoelle
    private bool isSpawn = true; // Flag zur Verfolgung der Bewegung
    public bool isHimmel = false;
    public bool isHoelle = false;
    private bool isMoveRight = false;
    private bool isMovingUp = false;
    private bool isMovingDown = false;

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        MoveRight();

        if (isMovingUp && !isHoelle)
        {
            MoveUp();
        }

        if (isMovingDown && !isHimmel)
        {
            MoveDown();
        }
    }

    public void MoveRight()
    {
        // Wenn das Objekt sich bewegen soll und noch nicht über die Stop-X-Koordinate hinaus bewegt hat
        if (isMoveRight && transform.position.x < stopXCoordinate)
        {
            isSpawn = false;
            // Bewegung des Objekts nach rechts
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            isMoveRight = false;
        }
    }

    public void MoveUp()
    {
        if (isMovingUp && !isSpawn && !isMoveRight && transform.position.y < stopHimmel)
        {
            transform.Translate(Vector3.up * upSpeed * Time.deltaTime);
            isHimmel = true;
            isHoelle = false;
        }
        else
        {
            isMovingUp = false;
        }
    }

    public void MoveDown()
    {
        if (isMovingDown && !isSpawn && !isMoveRight && transform.position.y > stopHoelle)
        {
            transform.Translate(Vector3.down * downSpeed * Time.deltaTime);
            isHoelle = true;
            isHimmel = false;
        }
        else
        {
            isMovingDown = false;
        }
    }

    // Für Button_Next on click, Methode zum Starten und Stoppen der Bewegung
    public void RightObj()
    {
        isMoveRight = true;
        isMovingUp = false;
        isMovingDown = false;
    }

    // Für Button_Himmel on click, Methode zum Starten und Stoppen der Bewegung
    public void UpObj()
    {
        isMovingUp = true;
        isMoveRight = false;
        isMovingDown = false;
    }

    // Für Button_Hoelle on click, Methode zum Starten und Stoppen der Bewegung
    public void DownObj()
    {
        isMovingDown = true;
        isMoveRight = false;
        isMovingUp = false;
    }
    public void StartMovingRightAutomatically()
    {
        if (transform.GetSiblingIndex() == 0)
        {
            RightObj();
        }
    }
}
