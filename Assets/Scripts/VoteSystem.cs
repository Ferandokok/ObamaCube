using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VoteSystem : MonoBehaviour
{
    public TMP_Text p1;
    public TMP_Text p2;
    public TMP_Text p3;
    public TMP_Text p4;
    public TMP_Text p5;

    public List<string> playerNames;

    private Dictionary<string, int> votes = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < playerNames.Count; i++)
        {
            switch (i)
            {
                case 0:
                    p1.text = playerNames[i];
                    break;
                case 1:
                    p2.text = playerNames[i];
                    break;
                case 2:
                    p3.text = playerNames[i];
                    break;
                case 3:
                    p4.text = playerNames[i];
                    break;
                case 4:
                    p5.text = playerNames[i];
                    break;
                default:
                    break;
            }

            votes[playerNames[i]] = 0;
        }
    }

    public void Vote(string playerName)
    {
        votes[playerName]++;
    }

    public string GetWinner()
    {
        string winner = "";
        int highestVotes = 0;

        foreach (KeyValuePair<string, int> pair in votes)
        {
            if (pair.Value > highestVotes)
            {
                highestVotes = pair.Value;
                winner = pair.Key;
            }
        }

        return winner;
    }
}