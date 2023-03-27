using UnityEngine;
using UnityEngine.UI;

public class ThemeSelector : MonoBehaviour
{
    Image img;
    Button btn;

    public int themeNumber;

    [SerializeField] Sprite selected;
    [SerializeField] Sprite unselected;
    [SerializeField] SelectedThemes selectedThemes;

    bool isSelected;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


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

            selectedThemes.themes[themeNumber] = false;
        }
        else
        {
            isSelected = true;
            img.sprite = selected;

            selectedThemes.themes[themeNumber] = true;
        }
    }
}