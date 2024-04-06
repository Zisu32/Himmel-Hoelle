using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI podestText;
    private MoveManager moveManager;

    private void Start()
    {
        moveManager = FindFirstObjectByType<MoveManager>(); // Find the MoveManager in the scene
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Podest"))
        {
            if (moveManager != null)
            {
                switch (moveManager.currentIndex)
                {
                    case 0:
                        podestText.text = "Text 1";
                        break;
                    case 1:
                        podestText.text = "Text 2";
                        break;
                    case 2:
                        podestText.text = "Text 3";
                        break;
                    case 3:
                        podestText.text = "Text 4";
                        break;
                    case 4:
                        podestText.text = "Text 5";
                        break;
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}