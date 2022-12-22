using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonProperties : MonoBehaviour
{   
    public DropDownScript dpscript;
    public PrefManagement pref;
    RectTransform rect;
    Vector2 buttonsize;
    
    void Awake() {
        rect = GetComponent<RectTransform>();
        dpscript.SetDpvalue(PlayerPrefs.GetInt("Bsize"));
    }

    void Update() {
        buttonsize = new Vector2(PlayerPrefs.GetInt("Bsize"),PlayerPrefs.GetInt("Bsize"));
        rect.sizeDelta = buttonsize;
        switch (dpscript.GetDPvalue())
        {
            case 0:
                PlayerPrefs.SetInt("Bsize", 60);
                break;
            case 1:
                PlayerPrefs.SetInt("Bsize", 80);
                break;
            case 2:
                PlayerPrefs.SetInt("Bsize", 100);
                break;
            case 3:
                PlayerPrefs.SetInt("Bsize", 120);
                break;
        }
        
    }
}
