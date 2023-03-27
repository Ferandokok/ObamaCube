using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReadTextFile : MonoBehaviour
{

    [SerializeField]
    public TextAsset textFile;

    [SerializeField]
    public string[] textPromts;

    // Start is called before the first frame update
    void Start()
    {
        readTextFile();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < textPromts.Length; i++)
        {
            Debug.Log(textPromts[i]);
        }
    }

    void readTextFile()
    {
        textPromts = textFile.text.Split('\n');
    }
}
