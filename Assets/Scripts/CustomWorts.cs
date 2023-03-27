using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UIElements;
using UnityEditor;

public class CustomWorts : MonoBehaviour
{
    // Start is called before the first frame update

    public string[] customWord;

    string path = "Assets/Resources/Words/custom.txt";

    void Start()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/resources/Prompts/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateTextFile()
    {
        string txtDocumentName = "Assets/Resources/Words/" + "custom " + ".txt";
    }

    //write to file
    void WriteTiFile()
    {
        
    }


}
