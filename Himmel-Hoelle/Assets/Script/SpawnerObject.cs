using UnityEngine;

public class SpawnerObject : MonoBehaviour
{
    public float moveSpeed = 5f; // Geschwindigkeit der Bewegung
    public float upSpeed = 5f;
    public float downSpeed = 5f;
    public float stopXCoordinate = 0f; // X-Koordinate zum Stoppen
    private bool isMoveRight = false; // Flag zur Verfolgung der Bewegung
    public bool isMovingUp = false;
    public bool isMovingDown = false;

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        moveRight();

        if (isMovingUp)
        {
            MoveUp();
        }

        if (isMovingDown)
        {
            MoveDown();
        }
    }

    public void moveRight()
    {
        // Wenn das Objekt sich bewegen soll und noch nicht über die Stop-X-Koordinate hinaus bewegt hat
        if (isMoveRight && transform.position.x < stopXCoordinate)
        {
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
        transform.Translate(Vector3.up * upSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down * downSpeed * Time.deltaTime);
    }

    // Für Button_Next on click, Methode zum Starten und Stoppen der Bewegung
    public void RightMovement()
    {
        // Wenn das Objekt bereits in Bewegung ist, stoppen
        if (isMoveRight)
        {
            isMoveRight = false;
        }
        // Andernfalls die Bewegung starten
        else
        {
            isMoveRight = true;
        }
    }

    public void UpObj()
    {
        // Wenn das Objekt bereits in Bewegung nach oben ist, stoppen
        if (isMovingUp)
        {
            isMovingUp = false;
        }
        // Andernfalls die Bewegung nach oben starten
        else
        {
            isMovingUp = true;
        }
    }

    public void DownObj()
    {
        if (isMovingDown)
        {
            isMovingDown = false;
        }
        // Andernfalls die Bewegung nach oben starten
        else
        {
            isMovingDown = true;

        }
    }
}