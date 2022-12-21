using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCore : MonoBehaviour
{
    [SerializeField] bool OnGround;
    float CoinCount;
    float Hp = 100;
    void Update()
    {
        
    }

    public void _LoadScene(int Scene) {
        GetComponent<Gameinputs>().enabled = false;
        SceneManager.LoadScene(Scene);
    }

    private void OnCollisionStay2D(Collision2D CallObj) {
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