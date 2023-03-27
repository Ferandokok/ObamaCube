using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class VotingSystem2 : MonoBehaviour
{
    public TMP_Text voteInstructions;
    public TMP_Text voteResults;

    private List<string> playerNames = new List<string>();
    private Dictionary<string, int> voteCount = new Dictionary<string, int>();

    public void InitializeVoting(List<string> names)
    {
        playerNames = names;
        voteInstructions.text = "Vote for a player:";
        foreach (string playerName in playerNames)
        {
            voteCount[playerName] = 0;
        }
    }

    public void CastVote(string playerName)
    {
        if (playerNames.Contains(playerName))
        {
            voteCount[playerName]++;
            voteInstructions.text = "Vote for another player or press submit to finish voting.";
        }
    }

    public void SubmitVotes()
    {
        int maxVotes = 0;
        string winner = "";
        foreach (KeyValuePair<string, int> entry in voteCount)
        {
            if (entry.Value > maxVotes)
            {
                maxVotes = entry.Value;
                winner = entry.Key;
            }
        }
        voteResults.text = "The winner is: " + winner + " with " + maxVotes + " votes!";
    }
}