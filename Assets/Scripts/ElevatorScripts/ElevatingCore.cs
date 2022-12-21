using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatingCore : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] float levelheight;
    [SerializeField] float liftspeed;
    bool leviating = false;
    bool heightReached;
    void Update()
    {
        if (door.GetComponent<DoorScript>().CheckForCaged() && transform.position.y < levelheight) {
            transform.Translate(Vector2.up * liftspeed * Time.deltaTime);
            liftspeed += 3/60;
            leviating = true;
        } else {
            leviating = false;
        }

        if (transform.position.y >= levelheight) {
            heightReached = true;
        }

        
    }

    public bool CheckheightR() {
        return heightReached;
    }

    public bool ifelevating() {
        return leviating;
    }

    public float GetLevelH() {
        return levelheight;
    }
}
