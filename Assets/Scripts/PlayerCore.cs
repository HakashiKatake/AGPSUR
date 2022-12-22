using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCore : MonoBehaviour
{
    [SerializeField] bool OnGround;
    public float CoinCount;
<<<<<<< HEAD
=======
    float Hp = 100;
>>>>>>> 5f922ef032bf2b73f1620b610feeffa41cd1dbd4
    [SerializeField] TMP_Text coinScore;

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
            coinScore.text = CoinCount + " / 3";
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