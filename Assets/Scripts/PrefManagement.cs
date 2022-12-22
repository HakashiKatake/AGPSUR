using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefManagement : MonoBehaviour
{

   public void Setint(string KeyName, int Value) {
    PlayerPrefs.SetInt(KeyName, Value);
   }

   public void Getint(string KeyName) {
    PlayerPrefs.GetInt(KeyName);
   }
    
}