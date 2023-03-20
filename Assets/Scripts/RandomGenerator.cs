using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    //only use text legacy
    public GameObject TextBox;
    public int TheNumber;

     void Awake()
    {
        RandomGenerate();
    }
    

    public void RandomGenerate()
    {
        TheNumber = Random.Range(1111, 9999);
        TextBox.GetComponent<Text>().text = "" + TheNumber;
    }

}
