using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ReadTextFile : MonoBehaviour
{

    SelectedThemes selectedThemes;


    [SerializeField]
    public TextAsset[] wordsFile;
    public TextAsset[] promptsFile;
    List<string> listWords = new List<string>();
    List<string> listPrompt = new List<string>();

    [SerializeField]
    public string[] arrayWords;
    public string[] arrayPrompt;
    

    


    void Awake()
    {
        ReadTextFileWords(wordsFile[6]);
        ReadTextFilePrompt(promptsFile[6]); 

        if (GameObject.Find("SelectedThemes"))
        {
        selectedThemes = GameObject.Find("SelectedThemes").GetComponent<SelectedThemes>();
        }
    }

    // Start is called before the first frame updates
    void Start()
    {
        if (GameObject.Find("SelectedThemes"))
        {
            for (int i = 0; i < selectedThemes.themes.Length; i++)
            {
                if (selectedThemes.themes[i])
                {
                    ReadTextFileWords(wordsFile[i]);
                    ReadTextFilePrompt(wordsFile[i]);
                }
            }   
        }
    }


    void ReadTextFileWords(TextAsset words)
    {
        arrayWords = words.text.Split('\n');
        listWords.AddRange(arrayWords);
    }
    void ReadTextFilePrompt(TextAsset prompt)
    {
        arrayPrompt = prompt.text.Split('\n');
        listPrompt.AddRange(arrayWords);
    }
}
