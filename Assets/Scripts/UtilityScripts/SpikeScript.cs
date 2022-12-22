using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    //[SerializeField] Vector3 respawnpoint;
    [SerializeField] GameObject _player;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            _player.GetComponent<PlayerCore>()._LoadScene(2);
        }
        
    }

    void Update()
    {
        
    }
}
