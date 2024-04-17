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
                        podestText.text = "Ich schwöre bei den Sternen des Feywood, ich habe niemals einen Pilz berührt! Ich bin eine Hüterin der Natur, nicht eine Diebin. Meine Verbindung zum Wald ist tiefer als Worte es beschreiben können. Jede Pflanze, jedes Tier, sie sind wie Familie für mich. Es tut mir leid, dass ich nicht mehr helfen kann, aber ich bin genauso verwirrt und bestürzt wie jeder andere über das Verschwinden der Pilze.";
                        break;
                    case 1:
                        podestText.text = "Ich bin ein Jäger, kein Dieb! Ich habe besseres zu tun, als mich mit so etwas herumzuschlagen. Mein Tag besteht aus der Jagd nach wilden Tieren und dem Schutz dieser Gärten vor gefährlichen Eindringlingen. Warum sollte ich mir die Mühe machen, Pilze zu stehlen? Es ist lächerlich, überhaupt daran zu denken.";
                        break;
                    case 2:
                        podestText.text = "Warum sollte ich die Pilze stehlen? Ich könnte viel schönere Dinge tun, als mich mit so etwas zu beschäftigen. Es muss jemand anderes gewesen sein. Mein Leben ist voller Abenteuer und Magie. Ich fliege durch die Lüfte, erkunde verborgene Orte und lerne von den Weisheiten des Waldes. Das Sammeln von Pilzen liegt nicht in meiner Natur.";
                        break;
                    case 3:
                        podestText.text = "Okay, die Pilze hätte ich super gebrauchen können, um meine Experimente zu verbessern. Aber klauen? Nein, das würde ich niemals wagen! Ich bin ein Forscher. Die Welt bietet so viele Möglichkeiten, so viele Ressourcen. Warum sollte ich mir die Mühe machen, etwas zu nehmen, das mir nicht gehört? Auch, wenn ich nicht immer der Vorzeigebewohner bin, steheln würde ich niemals.";
                        break;
                    case 4:
                        podestText.text = "Ich würde niemals etwas tun, um den Garten zu schädigen. Die Pilze sind ein wichtiger Teil unseres Ökosystems. Es muss jemand anders gewesen sein. Meine Verbindung zur Natur ist meine Stärke und meine Leidenschaft. Ich beschütze und pflege diesen Garten, als wäre er mein eigenes Kind. Die Idee, dass ich irgendjemandem schaden würde, ist absurd. Ich bin eine Hüterin, eine Beschützerin, nicht eine Diebin.";
                        break;
                    case 5:
                        podestText.text = "Ich habe keine Zeit für solche kindischen Spiele. Lass mich in Ruhe, oder ich werde dich zermalmen! Mein Leben besteht aus Kampf und Überleben. Jeden Tag muss ich mich den Gefahren des Waldes stellen, um meine Leute zu beschützen. Ich habe keine Zeit für Diebstahl oder Intrigen. Ich lebe nach meinen eigenen Regeln, und niemand wird mich davon abbringen.";
                        break;
                    case 6:
                        podestText.text = "Ich habe nichts gesehen und nichts gehört. Ich war den ganzen Tag damit beschäftigt, Blumen zu arrangieren. Bitte, lass mich in Frieden. Ich finde Trost und Freude in den kleinen Dingen des Lebens, wie dem Arrangieren von Blumen und dem Beobachten der Natur. Warum sollte ich meine Zeit damit verschwenden, mich mit Diebstahl zu beschäftigen? Es liegt nicht in meiner Natur, anderen Schaden zuzufügen.";
                        break;
                    case 7:
                        podestText.text = "Ich bin hier, um den Wald zu beschützen, nicht um seine Bewohner zu belästigen. Die Pilze interessieren mich nicht. Ich habe wichtigeres zu tun. Als Wächter des Waldes ist es meine Aufgabe, die Balance zu bewahren und die Bewohner zu beschützen. Ich diene einer höheren Mission und werde nicht von trivialen Angelegenheiten abgelenkt.";
                        break;
                    case 8:
                        podestText.text = "Warum sollte ich mich mit Pilzen abgeben, wenn ich so viel mächtigere Zutaten zur Verfügung habe? Es wäre unter meiner Würde, mich mit so etwas zu beschäftigen. Ich bin eine Hexe, eine Magierin, eine Beherrscherin der Elemente. Ich habe meine eigenen Ziele und werde nicht auf solche Tricks hereinfallen.";
                        break;
                    case 9:
                        podestText.text = "Oh, die Pilze? Die sahen schon verdammt lecker aus, aber ich habe mich nie getraut, zu fragen.... Ich bin ein Geschichtenerzähler, ein Sammler von Wissen und Geschichten. Meine Tage sind angefüllt mit Entdeckungen und Abenteuern. Warum sollte ich meine Zeit damit verschwenden, Pilze zu stehlen? Es ist viel interessanter, neue Orte zu erforschen und neue Geschichten zu sammeln. Die Idee, dass ich irgendjemandem schaden würde, ist lächerlich.";
                        break; 
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}