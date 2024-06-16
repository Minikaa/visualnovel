using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "To jest losowa linia dialogu.",
            "Chcia³bym coœ powiedzieæ, podejdŸ tu.",
            "Œwiat jest czasem dziwnym miejscem.",
            "Nie traæ nadziei, bêdzie lepiej",
            "To AKademia Zwierzaków!"
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            string longLine = "To jest bardzo d³uga linia która nie ma sensu, ale muszê zape³niæ j¹ ró¿n¹ treœci¹, poniewa¿ treœæ jest dobra, dobra, dobra , dobra i lepsza ni¿ lorem ipsum lol toœ coœ musia³am tu wpisaæ, dobra i lepsza ni¿ lorem ipsum lol toœ coœ musia³am tu wpisaæ,dobra i lepsza ni¿ lorem ipsum lol toœ coœ musia³am tu wpisaæ";
            if (Input.GetKeyDown(KeyCode.Space)) //to dotyczy klikniêcia spacji, bêdzie trzeba to wymieniæ na klikniêcie ekranu NA RAZIE ZOSTAWIAM BO TRZEBA JAKOŒ SPRAWDZAÆ NA KOMPIE
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLine);
                //architect.Build(lines[Random.Range(0, lines.Length)]);
            }
            else if (Input.GetKeyDown(KeyCode.A)) //to dotyczy klikniêcia litery A, zeby wysypa³o ca³y tekst, chyba bêdzie trzeba to usun¹æ.
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }

    }
}
