using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ReadTextFile : MonoBehaviour
{

    [SerializeField]
    public TextAsset textFile;

    [SerializeField]
    public string[] textPromts;

    public string listWords;


    // Start is called before the first frame update
    void Start()
    {
        textFile = Resources.Load<TextAsset>("Resources/Words/" + listWords + ".txt");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void readTextFile(TextAsset Promts)
    {
        textPromts = textFile.text.Split('\n');
    }
}
