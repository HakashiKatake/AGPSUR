using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGet : MonoBehaviour
{
    RectTransform rect;
    void Awake()
    {
        rect = GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(PlayerPrefs.GetInt("Bsize"),PlayerPrefs.GetInt("Bsize"));
        
    }
}
