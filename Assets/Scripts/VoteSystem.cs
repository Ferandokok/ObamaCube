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
        
    }
    public void Update()
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
        ShowVoteResults();
        return winner;
    }
    public void VoteForPlayer1()
    {
        if (playerNames.Count > 0)
        {
            FindObjectOfType<VoteSystem>().Vote(playerNames[0]);
        }
    }
    public void VoteForPlayer2()
    {
        if (playerNames.Count > 1)
        {
            FindObjectOfType<VoteSystem>().Vote(playerNames[1]);
        }
    }
    public void VoteForPlayer3()
    {
        if (playerNames.Count > 2)
        {
            FindObjectOfType<VoteSystem>().Vote(playerNames[2]);
        }
    }
    public void VoteForPlayer4()
    {
        if (playerNames.Count > 3)
        {
            FindObjectOfType<VoteSystem>().Vote(playerNames[3]);
        }
    }
    public void VoteForPlayer5()
    {
        FindObjectOfType<VoteSystem>().Vote(playerNames[4]);
    }
    public void ShowVoteResults()
    {
        foreach (KeyValuePair<string, int> pair in votes)
        {
            string playerName = pair.Key;
            int numVotes = pair.Value;

            // Find the TMP_Text component for the player with this name
            TMP_Text playerText = null;
            switch (playerName)
            {
                case "Player1":
                    playerText = p1;
                    break;
                case "Player2":
                    playerText = p2;
                    break;
                case "Player3":
                    playerText = p3;
                    break;
                case "Player4":
                    playerText = p4;
                    break;
                case "Player5":
                    playerText = p5;
                    break;
                default:
                    break;
            }

            
            playerText.text = playerName + " (" + numVotes + " votes)";
        }
    }
}