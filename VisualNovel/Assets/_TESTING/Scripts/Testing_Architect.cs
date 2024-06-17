using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines = new string[5]
        {
            "To jest losowa linia dialogu.",
            "Chcia�bym co� powiedzie�, podejd� tu.",
            "�wiat jest czasem dziwnym miejscem.",
            "Nie tra� nadziei, b�dzie lepiej",
            "To AKademia Zwierzak�w!"
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S)) //to dotyczy klawisza S , trzeba bedzie to zmienic
                architect.Stop();

            string longLine = "To jest bardzo d�uga linia kt�ra nie ma sensu, ale musz� zape�ni� j� r�n� tre�ci�, poniewa� tre�� jest dobra, dobra, dobra , dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�, dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�,dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�";
            if (Input.GetKeyDown(KeyCode.Space)) //to dotyczy klikni�cia spacji, b�dzie trzeba to wymieni� na klikni�cie ekranu NA RAZIE ZOSTAWIAM BO TRZEBA JAKO� SPRAWDZA� NA KOMPIE
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
            else if (Input.GetKeyDown(KeyCode.A)) //to dotyczy klikni�cia litery A, zeby wysypa�o ca�y tekst, chyba b�dzie trzeba to usun��.
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }
            // dla mobilnych:
            /*if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    string longLine = "To jest bardzo d�uga linia kt�ra nie ma sensu, ale musz� zape�ni� j� r�n� tre�ci�, poniewa� tre�� jest dobra, dobra, dobra , dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�, dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�,dobra i lepsza ni� lorem ipsum lol to� co� musia�am tu wpisa�";
                    if (architect.isBuilding)
                    {
                        if (!architect.hurryUp)
                            architect.hurryUp = true;
                        else
                            architect.ForceComplete();
                    }
                    else
                    {
                        architect.Build(longLine);
                        // architect.Build(lines[Random.Range(0, lines.Length)]);
                    }
                }
            }*/
        }

    }
}
