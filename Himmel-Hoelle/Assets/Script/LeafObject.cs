using UnityEngine;

public class LeafObject : MonoBehaviour
{
    public float moveSpeed = 500f;
    public float upPosition = 1000f;
    public float downPosition = -1000f;
    private bool movingUp = false;
    private bool movingDown = false;
    private bool returningToInitialPosition = false;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
        //moveManager = FindFirstObjectByType<MoveManager>();
    }

    void Update()
    {
        if (movingUp)
        {
            MoveUp();
        }
        else if (movingDown)
        {
            MoveDown();
        }
        else if (returningToInitialPosition)
        {
            ReturnToInitialPosition();
        }
    }

    void MoveUp()
    {
        if (transform.position.y < upPosition)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else
        {
            movingUp = false;
            returningToInitialPosition = true;
        }
    }

    void MoveDown()
    {
        if (transform.position.y > downPosition)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            movingDown = false;
            returningToInitialPosition = true;
        }
    }

    void ReturnToInitialPosition()
    {
        if (transform.position != initialPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, initialPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            returningToInitialPosition = false;
        }
    }

    public void MoveLeafUp()
    {
        movingUp = true;
        movingDown = false;
        returningToInitialPosition = false;
    }

    public void MoveLeafDown()
    {
        movingDown = true;
        movingUp = false;
        returningToInitialPosition = false;
    }
}
