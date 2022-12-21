using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevationFollower : MonoBehaviour
{
    [SerializeField] GameObject core; 
    [SerializeField] float liftspeed;
    void Update()
    {
        if (core.GetComponent<ElevatingCore>().ifelevating()) {
            transform.Translate(Vector2.up * liftspeed * Time.deltaTime);
            liftspeed += 3/60;
        }
    }
}
