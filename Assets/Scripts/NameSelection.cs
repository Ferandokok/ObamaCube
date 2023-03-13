using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class NameSelection : MonoBehaviour
{

    public TMP_InputField nameInput;
    public TMP_Text playerNameText;
    public Button submitButton;
    public int maxPlayers = 4;
    public List<string> playerNames = new List<string>();

    private int currentPlayer = 0;

    void Start()
    {
        playerNameText.text = "Player " + (currentPlayer + 1);
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
                playerNameText.text = "Player " + (currentPlayer + 1);
                nameInput.text = "";
            }
            else
            {
                playerNameText.text = "All players selected";
                nameInput.gameObject.SetActive(false);
                submitButton.gameObject.SetActive(false);
            }
        }
    }
}