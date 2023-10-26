using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
   /* public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Wind Sword of Agrammar";

    public int CurrentGold = 32;
    public int DiceRoll = 7;

    string CharacterAction = "Attack";
    int a = 8;
    int b = 4;
   */
    string MyName = "William Abildtrup";

    // Start is called before the first frame update
    void Start()
    {
        /*Thievery();
        OpenTreasureChamber();
        PrintCharacterAction();
        RollDice();
        int Max = CalculateMax(a,b);
        Debug.LogFormat("Det her er den højeste: {0}",Max); */

        FindPartyMember(0, MyName);
      
    }

   public void FindPartyMember(int index, string name)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        QuestPartyMembers.Insert(index,name);
        int listLength = QuestPartyMembers.Count;
        
        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }

    }
    /*
   public int CalculateMax (int n, int m)
    {
        if (n > m)
        {
            return n;
        }
        else
        {
            return m;
        }
    }
   public void RollDice()
    {
        switch(DiceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad...");
                break;
            case 20:
                Debug.Log("Critical damage! You killed the creature");
                break;
            default:
                Debug.Log("You completely missed, terrible display of skill");
                break;
        }

    }

   public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion Sent.");
                break;
            case "Attack":
                Debug.Log("Fight them now!");
                break;
            default:
                Debug.Log("Shields up");
                break;
        }
    }

   public void OpenTreasureChamber()
    {
    if (PureOfHeart && RareItem == "Wind Sword of Agrammar")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have not the spirit to open this chamber");
            }
            else
            {
                Debug.Log("The treasure of Agrammar is yours");
            }
        }
    else
        {
            Debug.Log("You need a relic and be pure of heart to open this chamber");
        }
    }

   public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You are rolling in it");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much to steal");
        }
        else
        {
            Debug.Log("Looks like you are comfortable");
        }
    }
    

    /// <summary>
    /// Adds 2 variables together
    /// </summary>
    void ComputeAge()
    {
        int CurrentAge = 20;
        int AddedAge = 1;
        Debug.Log(CurrentAge + AddedAge);
    }
    */
    // Update is called once per frame
    void Update()
    {
        /*
         * Commenting
         * for 
         * a 
         * long
         * while
         * */
    }
}
