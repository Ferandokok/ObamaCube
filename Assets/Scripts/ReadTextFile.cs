using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ReadTextFile : MonoBehaviour
{

    SelectedThemes selectedThemes;


    [SerializeField]
    public TextAsset[] textFile;
    List<string> listWords = new List<string>();

    [SerializeField]
    public string[] arrayWords;

    


    void Awake()
    {
        //selectedThemes = GameObject.Find("SelectedThemes").GetComponent<SelectedThemes>();
    }

    // Start is called before the first frame updates
    void Start()
    {
        //for (int i = 0; i < selectedThemes.themes.Length; i++)
        //{
        //    if (selectedThemes.themes[i])
        //    {

        //    }
        //}
        readTextFile(textFile[0]);
        readTextFile(textFile[1]);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void readTextFile(TextAsset words)
    {
        arrayWords = words.text.Split('\n');
        listWords.AddRange(arrayWords);
    }
}
