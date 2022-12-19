using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gameinputs : MonoBehaviour
{
    [SerializeField] float Jumpf;
    [SerializeField] float speed;
    PlayerInputActions PlayerInput;
    Rigidbody2D PlayerRb;
    

    void Awake() {
        PlayerRb = GetComponent<Rigidbody2D>();

        PlayerInput = new PlayerInputActions();
        PlayerInput.Player.Enable();
        PlayerInput.Player.Jump.performed += Jump;
        PlayerInput.Player.Movement.performed += Movement_performed;
    }

    private void Movement_performed(InputAction.CallbackContext context) {}


    void Update() {
        Vector2 direction = PlayerInput.Player.Movement.ReadValue<Vector2>();
        transform.Translate(Vector2.right * direction.x * speed * Time.deltaTime);
    }

    public void Jump(InputAction.CallbackContext context) {
        if (context.performed && GetComponent<PlayerCore>().GetOnground())
        {
            PlayerRb.AddForce(Vector2.up * Jumpf*50);
        }
        
    }
}
