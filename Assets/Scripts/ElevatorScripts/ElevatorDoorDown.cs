using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorDown : MonoBehaviour
{   
    
    [SerializeField] float Doorspeed;
    [SerializeField] GameObject Elevatorwalldown;
    void Update()
    {
        if (Elevatorwalldown.GetComponent<DoorSensor>().GetElevationSensor() && transform.position.y > 0) {
            transform.Translate(Vector2.down * Doorspeed * Time.deltaTime);
        }
    }
}
