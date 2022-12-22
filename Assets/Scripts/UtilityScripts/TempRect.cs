using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempRect : MonoBehaviour
{
    [SerializeField] float respawnDelay;
    [SerializeField] float Falldelay;
    [SerializeField] float speed;
    float counter = 0;
    float respawnCounter = 0;
    bool onplat;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
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
                if(respawnCounter < respawnDelay)
                {
                    respawnCounter += Time.deltaTime;
                }
                else
                {
                    onplat = false;
                    counter = 0;
                    respawnCounter = 0;
                    transform.position = startPosition;
                }
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
    }
}
