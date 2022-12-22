using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownScript : MonoBehaviour
{
    [SerializeField] TMP_Dropdown ButtonSize_DP;
    //int dpvalue;
    
    public int GetDPvalue() {
        return ButtonSize_DP.value;
    }

    public void SetDpvalue(int _value) {
        ButtonSize_DP.value = _value;
    }
}
