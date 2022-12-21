using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{   
    [SerializeField] bool stagetype = false;
    [SerializeField] float speed;
    [SerializeField] float ElevationDis;
    [SerializeField] GameObject _Player;
    [SerializeField] GameObject Liftfloor;
    [SerializeField] GameObject Elevator;
    [SerializeField] bool frontgate = false;
    [SerializeField] int NextSceneIndex;
    bool topreached = false;
    bool Encaged = false;

    public PlayerCore playerScript;

    void Start() {
        if (stagetype) {
            Encaged = true;
        }
    }
    
    void Update()
    {
        if (_Player.GetComponent<PlayerCore>().GetCoinCount() >= 3 && transform.position.y <= ElevationDis && topreached == false && frontgate == false) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (transform.position.y >= ElevationDis) {
            topreached = true;
        }

        if (topreached && Liftfloor.GetComponent<DoorSensor>().GetElevationSensor() && Encaged == false && frontgate == false) {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y < 0 && topreached) {
            Encaged = true; 
        }

        if (Elevator.GetComponent<ElevatingCore>().CheckheightR() && frontgate == true && transform.position.y < ElevationDis + Elevator.GetComponent<ElevatingCore>().GetLevelH() && stagetype == true) {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Elevator.GetComponent<ElevatingCore>().CheckheightR() && stagetype == false) {
            _Player.GetComponent<Gameinputs>().DisableControls();
            playerScript.CoinCount = 0;
            Destroy(_Player);
            SceneManager.LoadScene(NextSceneIndex);
        }
        
    }

    public bool CheckForCaged() {
        return Encaged;
    }
}
