using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMoveRect : MonoBehaviour
{
    [SerializeField] float movepos;
    [SerializeField] float speed;
    [SerializeField] GameObject _player;
    bool onplat = false;
    void Update()
    {
        if (onplat && transform.position.x > -movepos) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            _player.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (onplat == false && transform.position.x < 0) {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            onplat = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        onplat = false;
    }
}
