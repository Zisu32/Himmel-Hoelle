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
                        podestText.text = "Ich war tief im Wald und habe die Vögel singen gehört, als plötzlich der Rauch aufstieg. Es war furchtbar!";
                        break;
                    case 1:
                        podestText.text = "Ich habe den Feuergeruch schon seit Tagen gespürt, aber ich konnte nichts tun, um es zu stoppen.";
                        break;
                    case 2:
                        podestText.text = "Ich sah einen Schatten davonhuschen, als das Feuer ausbrach. Es war jemand in der Nähe während ich mein abendliche Zigarette rauchte!";
                        break;
                    case 3:
                        podestText.text = "Die Bäume brannten viel zu schnell. Es muss Brandbeschleuniger gegeben haben.";
                        break;
                    case 4:
                        podestText.text = "Ich versuchte, das Feuer mit meinem Wasser zu löschen, aber es war zu spät.";
                        break;
                    case 5:
                        podestText.text = "Die Luft war voller Rauch und ich konnte kaum atmen. Es war wie ein Albtraum.";
                        break;
                    case 6:
                        podestText.text = "Ich habe gesehen, wie jemand schnell den Wald verließ, kurz bevor das Feuer ausbrach.";
                        break;
                    case 7:
                        podestText.text = "Ich sah verdächtige Gestalten in der Nähe des Waldes, als ich die Sterne beobachtete.";
                        break;
                    case 8:
                        podestText.text = "Ich hörte seltsame Geräusche in der Nacht, aber ich dachte, es sei nur der Wind.";
                        break;
                    case 9:
                        podestText.text = "Ich war zu beschäftigt damit, die Ruhe im Wald zu bewahren, um den Brand rechtzeitig zu bemerken.";
                        break; 
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}