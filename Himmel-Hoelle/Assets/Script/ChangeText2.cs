using UnityEngine;
using TMPro;

public class ChangeText2 : MonoBehaviour
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
                        podestText.text = "Ich war tief im Wald und habe die Vögel singen gehört, als plötzlich der Rauch aufstieg. Es war furchtbar! Die Luft war erstickend, und ich konnte das Knistern der Flammen hören. Mein Herz brach, als ich sah, wie der geliebte Wald in Flammen stand. Es war, als ob ein Teil meiner Seele mit jedem Baum verbrannte.";
                        break;
                    case 1:
                        podestText.text = "Ich habe den ganzen Tag schon das Gefühl gehabt, dass etwas schlimmes passieren wird, aber ich konnte nichts tun, um es zu stoppen. Meine Knie zitterten vor Angst, als ich das Knistern der Flammen näher zu meinem Bau kommen hörte. Die Natur selbst schrie vor Schmerz, als der Wald in einem infernalischen Feuersturm versank. Es war ein Alptraum...";
                        break;
                    case 2:
                        podestText.text = "Ich war mit Übungen meiner Lichtmagie beschäftigt, um endlich die Anerkennung zu bekommen, die mir niemand gewährt, als das Feuer ausbrach. Jemand ist ganz plötzlich an mir vorbei gerauscht und hat mich so aus der Fassung gebracht, dass ich in einen großen Laubhaufen fiel. Da hätte ich beinahe die Kontrolle über meine Magie verloren... Bei dieser Trockenheit hätte in Funken ausgereicht, um ein Inferno zu verursachen!";
                        break;
                    case 3:
                        podestText.text = "Die Bäume brannten viel zu schnell. Es muss Brandbeschleuniger gegeben haben. Der Geruch von verbranntem Holz und die Hitze der Flammen trieben mich zur Verzweiflung. Als Waldwächter fühle ich mich verpflichtet, den Wald zu beschützen, aber dieses Feuer war eine Macht, gegen die ich machtlos war. Wenn ich den Verantwortlichen erwische, wird er meine Wut zu spüren bekommen.";
                        break;
                    case 4:
                        podestText.text = "Ich versuchte, das Feuer mit meinem Wasser zu löschen, aber es war zu spät. Meine Tränen vermischten sich mit dem Wasser meiner Quellen, als ich versuchte, die Flammen zu ersticken. Aber das Feuer war stärker, als ich es je für möglich gehalten hätte. Ich fühle mich hilflos und traurig angesichts der Zerstörung, die über unseren geliebten Wald gekommen ist.";
                        break;
                    case 5:
                        podestText.text = "Die Luft war voller Rauch und ich konnte kaum atmen. Es war wie ein Albtraum. Mein Herz weinte, als ich sah, wie die ersten Strahlen der Sonne durch den Rauch brachen und das Ausmaß der Zerstörung offenbarten. Meine Freundin Seraphina wäre fast umgekommen, so nah war sie dem Brandherd gekommen... Ein Glück, dass Elara bei ihr war! Die beiden verstehen sich in letzter Zeit ziemlich gut...";
                        break;
                    case 6:
                        podestText.text = "Ja, ich war in der Nähe des Brandherdes, aber ich habe versucht, das Feuer zu löschen! Ich habe mein Bestes getan, um den Wald zu retten, glaubt mir! Die Rußspuren auf meiner Kleidung sind ein Beweis dafür, wie hart ich gekämpft habe, um die Flammen zu ersticken. Mein Herz blutet vor Trauer über das, was geschehen ist, und ich werde alles in meiner Macht Stehende tun, um Gerechtigkeit für unseren geliebten Wald zu erreichen.";
                        break;
                    case 7:
                        podestText.text = "Ich sah verdächtige Gestalten in der Nähe des Waldes, als ich die Sterne beobachtete. Die Schatten der Nacht verbargen ihre Identität, aber ihre bösen Absichten waren deutlich spürbar. Ich habe den Sternen geschworen, den Wald zu beschützen, und ich werde nicht zulassen, dass diejenigen, die das Feuer gelegt haben, ungestraft davonkommen.";
                        break;
                    case 8:
                        podestText.text = "Ich hatte unheimliches Glück, denn zum Zeitpunkt des Feuers war ich weit entfernt, ich habe kaum etwas mitbekommen – erst, als das Feuer bereits gelöscht war, kam ich her. Ich bin bloß froh, dass den Eichhörnchen dort nichts passiert ist – egal, wie viele Nüsse sie mir auch klauen, es wäre eine Schande, auf sie im Wald zu verzichten!";
                        break;
                    case 9:
                        podestText.text = "Ich war zu beschäftigt damit, die Ruhe im Wald zu bewahren, um den Brand rechtzeitig zu bemerken. Die Verantwortung als Beschützer des Fey wiegt schwer auf meinen Schultern, und ich habe den Wald zu allen Zeiten im Blick. Doch selbst meine Wachsamkeit konnte nicht verhindern, dass das Feuer ausbrach und unsere geliebten Wälder verwüstete. Ich fühle mich zutiefst betrübt und machtlos angesichts dieser Tragödie.";
                        break; 
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}