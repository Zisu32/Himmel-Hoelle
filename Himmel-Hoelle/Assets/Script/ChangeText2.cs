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
                        podestText.text = "<b>YRA:</b>\n \"Ich war tief im Wald und habe die Vögel singen gehört, als plötzlich der Rauch aufstieg. Es war furchtbar! Die Luft war erstickend, und ich konnte das Knistern der Flammen hören. Mein Herz brach, als ich sah, wie der geliebte Wald in Flammen stand. Es war, als ob ein Teil meiner Seele mit jedem Baum verbrannte.\"";
                        break;
                    case 1:
                        podestText.text = "<b>THALON:</b>\n \"Ich habe den ganzen Tag schon das Gefühl gehabt, dass etwas schlimmes passieren wird, aber ich konnte nichts tun, um es zu stoppen. Meine Knie zitterten vor Angst, als ich das Knistern der Flammen näher zu meinem Bau kommen hörte. Die Natur selbst schrie vor Schmerz, als der Wald in einem infernalischen Feuersturm versank. Es war ein Alptraum...\"";
                        break;
                    case 2:
                        podestText.text = "<b>ELARA:</b>\n \"Ich war mit meiner Lichtmagie beschäftigt, um die Anerkennung zu bekommen, die mir niemand gewährt. Jemand ist plötzlich an mir vorbei gerauscht und hat mich so aus der Fassung gebracht, dass ich in einen Laubhaufen fiel. Da hätte ich fast die Kontrolle verloren. Bei der Trockenheit hätte ein Funken ausgereicht, um ein Inferno zu verursachen!\"";
                        break;
                    case 3:
                        podestText.text = "<b>BRAN:</b>\n \"Die Bäume brannten zu schnell. Es muss Brandbeschleuniger gegeben haben. Als Waldwächter fühle ich mich verpflichtet, den Wald zu beschützen, aber dieses Feuer war eine Macht, gegen die ich machtlos war. Wenn ich den Verantwortlichen erwische, wird er meine Wut zu spüren bekommen.\"";
                        break;
                    case 4:
                        podestText.text = "<b>FINN:</b>\n \"Ich versuchte, das Feuer mit meinem Wasser zu löschen, aber es war zu spät. Aber das Feuer war stärker, als ich es je für möglich gehalten hätte. Ich fühle mich hilflos und traurig angesichts der Zerstörung, die über unseren geliebten Wald gekommen ist.\"";
                        break;
                    case 5:
                        podestText.text = "<b>AURORA:</b>\n \"Die Luft war voller Rauch und ich konnte kaum atmen. Meine Freundin Seraphina wäre fast umgekommen, so nah war sie dem Brandherd gekommen... Ein Glück, dass Elara bei ihr war! Die beiden verstehen sich in letzter Zeit ziemlich gut...\"";
                        break;
                    case 6:
                        podestText.text = "<b>RAELLE:</b>\n \"Ja, ich war in der Nähe des Brandherdes, aber ich habe versucht, das Feuer zu löschen! Die Rußspuren auf meiner Kleidung sind ein Beweis dafür, wie hart ich gekämpft habe, um die Flammen zu ersticken. Ich werde alles in meiner Macht Stehende tun, um Gerechtigkeit für unseren geliebten Wald zu erreichen.\"";
                        break;
                    case 7:
                        podestText.text = "<b>ORION:</b>\n \"Ich sah verdächtige Gestalten in der Nähe des Waldes, als ich die Sterne beobachtete. Die Schatten der Nacht verbargen ihre Identität, aber ihre bösen Absichten waren deutlich spürbar. Ich habe den Sternen geschworen, den Wald zu beschützen, und ich werde nicht zulassen, dass diejenigen, die das Feuer gelegt haben, ungestraft davonkommen.\"";
                        break;
                    case 8:
                        podestText.text = "<b>SERAPHINA:</b>\n \"Ich hatte unheimliches Glück, denn zum Zeitpunkt des Feuers war ich weit entfernt, ich habe kaum etwas mitbekommen – erst, als das Feuer bereits gelöscht war, kam ich her. Ich bin bloß froh, dass den Eichhörnchen dort nichts passiert ist – egal, wie viele Nüsse sie mir auch klauen, es wäre eine Schande, auf sie im Wald zu verzichten!\"";
                        break;
                    case 9:
                        podestText.text = "<b>AVALON:</b>\n \"Die Verantwortung als Beschützer des Fey wiegt schwer auf meinen Schultern, und ich habe den Wald zu allen Zeiten im Blick. Doch selbst meine Wachsamkeit konnte nicht verhindern, dass das Feuer ausbrach und unsere geliebten Wälder verwüstete. Ich fühle mich zutiefst betrübt und machtlos angesichts dieser Tragödie.\"";
                        break; 
                    default:
                        podestText.text = "Default Text";
                        break;
                }
            }
        }
    }
}