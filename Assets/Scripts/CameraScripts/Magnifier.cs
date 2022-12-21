using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] Vector3 magnification;
    bool Collision;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Collision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Collision = false;
        }
        
    }
    public bool checkforcollision() {
        return Collision;
    }

    public Vector3 SendMaginification() {
        return magnification;
    }

}
