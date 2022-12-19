using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] GameObject player;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 desiredpos = player.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredpos, speed * Time.deltaTime);
    }
}
