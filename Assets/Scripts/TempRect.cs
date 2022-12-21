using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempRect : MonoBehaviour
{      
    [SerializeField] float Falldelay;
    [SerializeField] float speed;
    float counter = 0;
    bool onplat;

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            onplat = true;
        }
    }

    void Update()
    {   
        if (onplat == true) {
            if (counter < Falldelay) {
                counter += Time.deltaTime;
            } else {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
    }
}
