using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    [SerializeField] Vector3 mainoffset;
    [SerializeField] GameObject _Camera;
    Vector3 kaydence = new Vector3(0,0,0);

    void Update()
    {   
        if (_Camera.GetComponent<Magnifier>().checkforcollision()) {
            kaydence = _Camera.GetComponent<Magnifier>().SendMaginification();
        } else {
            kaydence = new Vector3(0,0,0);
        }
        Vector3 desiredpos = player.transform.position - kaydence + offset;
        transform.position = Vector3.Lerp(transform.position, desiredpos, speed * Time.deltaTime);
    }
}