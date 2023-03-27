using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedThemes : MonoBehaviour
{
    public bool[] themes;

    void Start()
    {
        for (int i = 0; i <= themes.Length; i++)
        {
            Debug.Log(i);
            themes[i] = false;
        }
    }
}