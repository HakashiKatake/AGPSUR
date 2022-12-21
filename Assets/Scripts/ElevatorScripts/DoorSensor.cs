using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    
    bool InElevator;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D Callobj) {
        if (Callobj.gameObject.CompareTag("Player")) {
            InElevator = true;
        }
    }

    private void OnCollisionExit2D(Collision2D Callobj) {
        if (Callobj.gameObject.CompareTag("Player")) {
            InElevator = false;
        }
    }

    public bool GetElevationSensor() {
        return InElevator;
    }
}
