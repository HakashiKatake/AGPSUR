using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float ElevationDis;
    [SerializeField] GameObject _Player;
    void Update()
    {
        if (_Player.GetComponent<PlayerCore>().GetCoinCount() >= 3 && transform.position.y < ElevationDis) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
