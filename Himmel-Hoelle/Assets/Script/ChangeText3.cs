using UnityEngine;
using TMPro;

public class ChangeText3 : MonoBehaviour
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
                        podestText.text = "Ich war die erste Person am Tatort... Ich war zur falschen Zeit am falschen Ort. Bitte glaubt mir, ich würde niemals jemandem absichtlich Schaden zufügen! Ich kann nicht einmal eine Mücke zerquetschen... Meine Brille beschlug vor Tränen, als ich die leblose Fey-Leiche sah. Es tut mir so leid für das Opfer und seine Familie. Ich hoffe, der wahre Täter wird bald gefasst.";
                        break;
                    case 1:
                        podestText.text = "Ich mag vielleicht mysteriös wirken, aber ich versichere euch, ich habe nichts mit dem Tod dieser armen Seele zu tun. Ich war viel zu beschäftigt damit, die Geheimnisse des Feywoods zu erforschen. Meine Schritte hallten in der Stille wider, als ich am Tatort ankam. Möge das Echo der Wahrheit die Dunkelheit vertreiben.";
                        break;
                    case 2:
                        podestText.text = "Ich habe wirklich keine Ahnung, was passiert ist. Ich war viel zu beschäftigt damit, die Schönheit dieser magischen Wälder zu bewundern, um irgendjemandem etwas anzutun! Vor ein paar Stunden sind meine grade angezüchteten Glühwürmchenlarven geschlüpft, das sind viele hungrige Larvenmäuler, um die ich mich kümmern muss! Ich hoffe, der Täter wird schnell gefasst und zur Rechenschaft gezogen.";
                        break;
                    case 3:
                        podestText.text = "Ich bin vielleicht ein dunkler Fey, aber ich bin kein Mörder! Ihr könnt mir nicht einfach die Schuld zuschieben, nur weil ich anders aussehe! Mein Knurren erfüllte die Luft, ein anderes Raubtier so machtlos am Boden zu sehen. Sie war eine gute Werwölfin mit einer wunderschönen Singstimme. Dieser Vogel, der hatte ständig Streit mit ihr, ich bin sicher, dass er etwas damit zu tun hat.";
                        break;
                    case 4:
                        podestText.text = "Ich schwöre bei den Melodien der Wälder, ich habe nichts mit diesem schrecklichen Vorfall zu tun. Es brach mir das Herz, als ich die Leiche sah. Sie war die beste Sängerin des Waldes. wer soll den nun die musikalische Begleitung am Waldfest morgen übernehmen? Es ist eine Schande - Sie hätte sicher gewollt, dass es stattfindet. Ich schätze, dann muss ich mich wohl bereit erklären...";
                        break;
                    case 5:
                        podestText.text = "Ich gebe zu, ich bin ein Schelm, aber ich bin kein Mörder! Ihr müsst mir glauben, ich hatte nichts mit dem Tod dieser armen Seele zu tun! Ich hörte allerdings Stimmen im Wald, drei männliche und eine weibliche. Ob es die Täter sind kann ich nicht genau sagen... Allerdings hörte es sich nach einem aufgebrachten Streit an.";
                        break;
                    case 6:
                        podestText.text = "Ich könnte nicht einmal einem Blatt Wind zufügen, geschweige denn einer anderen Kreatur! Bitte glaubt mir, ich bin unschuldig! Als es geschehen sein muss war ich gerade auf der Suche nach Ivy, um mir einen Rat für ein Elixier zu holen, doch sie war nirgends zu finden, auch in ihrer Hütte nicht... Ich mache mir solche Sorgen, dass die Täter noch in unserer Mitte weilen! Was, wenn Marcy nur eine von vielen war?";
                        break;
                    case 7:
                        podestText.text = "Meine arme, arme Marcy! Sie war mein Ein und Alles – Heiraten wollten wir bald! Jetzt habe ich niemanden mehr... Wer auch immer schuld an ihrem Tod ist, hat mir das letzte Glück genommen. Bitte sorgt dafür, dass demjenigen die rechte Strafe erteilt wird. Der Gedanke, dass ich dieser Person täglich begegnen könnte, widert mich an! Ich bin untröstlich!";
                        break;
                    case 8:
                        podestText.text = "Ja, ich bin giftig, aber das bedeutet nicht, dass ich jemanden getötet habe! Ich war vollauf damit beschäftigt, meine Tränke zu brauen. Der arme Vladimir, ihm muss es schrecklich gehen! Ich als seine beste Freundin sollte mich direkt um ihn kümmern – er war doch so verliebt in Marcy, obwohl er so viel mehr verdient hätte... Er braucht sicher jemanden, der für ihn da ist.";
                        break;
                    case 9:
                        podestText.text = "Ich mag vielleicht einschüchternd wirken, aber ich schwöre bei den Wurzeln des Schicksalsbaums, ich habe nichts mit diesem abscheulichen Vorfall zu tun! Ich bin Stolz drauf, mich einen guten Freund von Marcy nennen zu dürfen, denn wie es aussieht hat sie sich ziemlich gewehrt! Möge ihr Mörder sich stellen und ihr so Ehre erweisen!";
                        break; 
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}