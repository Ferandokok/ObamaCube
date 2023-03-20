using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopySystem : MonoBehaviour
{
    public GameObject TextBox;

    public void CopyToClippoard()
    {
        {
            TextEditor te = new TextEditor();
            te.text = TextBox.GetComponent<Text>().text;
            te.SelectAll();
            te.Copy();
        }
    }

   
}
