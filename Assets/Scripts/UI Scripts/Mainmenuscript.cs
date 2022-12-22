using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuscript : MonoBehaviour
{
    public void OnClick_Play_Button() {
        SceneManager.LoadScene(1);
    }

    public void OnClick_Exit_Button() {
       Application.Quit();
    }

    public void OnClick_Settings_Button() {
        SceneManager.LoadScene(3);
    }

    void Update()
    {
        
    }
}
