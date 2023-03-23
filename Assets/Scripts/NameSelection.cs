using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class NameSelection : MonoBehaviour
{

    public TMP_InputField nameInput;

    public TMP_Text playerNameText;
    public TMP_Text playersList;
    public TMP_Text playerAmount;

    public Button submitButton;
<<<<<<< Updated upstream
=======
    
>>>>>>> Stashed changes
    public int maxPlayers = 5;
    public List<string> playerNames = new List<string>();

    

    private int currentPlayer = 0;

    void Start()
    {
        //playerNameText.text = "Player " + (currentPlayer + 1);
        submitButton.onClick.AddListener(SubmitName);
    }

    void SubmitName()
    {
        
        if (nameInput.text != "")
        {
            playerNames.Add(nameInput.text);
            currentPlayer++;
            
            if (currentPlayer < maxPlayers)
            {
                
                //playerNameText.text = "Player " + (currentPlayer + 1);
                nameInput.text = "";
            }
            else
            {
                playerNameText.text = "All players selected";
                nameInput.gameObject.SetActive(false);
                submitButton.gameObject.SetActive(false);
            }
            playersList.text = "";
            foreach (string playerName in playerNames)
            {
                playersList.text += playerName + "\n";
            }
            playerAmount.text = "Players: " + playerNames.Count;

        }
    }
}