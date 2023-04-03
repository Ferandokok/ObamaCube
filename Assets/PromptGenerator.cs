using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PromptGenerator : MonoBehaviour
{
    [SerializeField] private TextAsset prompts;
    [SerializeField] private TextAsset words;

    [SerializeField] private GameObject promptCountainer;
    [SerializeField] private GameObject wordCountainer;

    private TextMeshProUGUI promptText;
    private TextMeshProUGUI wordText;

    void Start()
    {
        
    }

    private void generateBox(GameObject container, int value)
    {
        GameObject box = new GameObject($"Box {value}" );
        box.transform.parent = container.transform;
    }

}
