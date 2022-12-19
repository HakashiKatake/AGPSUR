using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    [SerializeField] bool OnGround;
    float CoinCount;
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D CallObj) {
        if (CallObj.gameObject.CompareTag("Ground")) {
            OnGround = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D CallObj) {
        if (CallObj.gameObject.CompareTag("coin")) {
            CoinCount += 1;
            Destroy(CallObj.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D CallObj) {
        if (CallObj.gameObject.CompareTag("Ground")) {
            OnGround = false;
        }
    }

    public float GetCoinCount() {
        return CoinCount;
    }

    public bool GetOnground() {
        return OnGround;
    }
}