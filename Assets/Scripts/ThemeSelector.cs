using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelector : MonoBehaviour
{
    Image img;
    Button btn;

    [SerializeField] Sprite selected;
    [SerializeField] Sprite unselected;

    bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SwitchSelecMode);
    }

    void SwitchSelecMode()
    {
        if (isSelected)
        {
            isSelected = false;
            img.sprite = unselected;
        }
        else
        {
            isSelected = true;
            img.sprite = selected;
        }
    }
}
