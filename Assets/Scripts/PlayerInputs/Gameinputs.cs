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
    bool RightMovement = false;
    bool LeftMovement = false;
    bool Movement = false;
    

    void Awake() {
        PlayerRb = GetComponent<Rigidbody2D>();

        PlayerInput = new PlayerInputActions();
        PlayerInput.Player.Enable();
        PlayerInput.Player.Jump.started += Jump;
        PlayerInput.Player.Movement.performed += Movement_performed;
    }

    private void Movement_performed(InputAction.CallbackContext context) {}

    public void DisableControls() {
        PlayerInput.Player.Disable();
    }

    public int GetMovementAxis() {
        if (Movement == true) {
            if (RightMovement == true) {
            return 1;
            }
            if (LeftMovement == true) {
            return -1;
            }
        }
        return 0;
    }

    void Update() {
        Vector2 direction = PlayerInput.Player.Movement.ReadValue<Vector2>();
        transform.Translate(Vector2.right * direction.x * speed * Time.deltaTime);
        if (direction.x == 0) {
            Movement = false;
        } else {
            Movement = true;
        }

        if (direction.x > 0 && Movement == true) {
            RightMovement = true;
            LeftMovement = false;
        }

        if (direction.x < 0 && Movement == true) {
            RightMovement = false;
            LeftMovement = true;
        }
        
    }

    

    public void Jump(InputAction.CallbackContext context) {
        if (context.performed && GetComponent<PlayerCore>().GetOnground())
        {
            PlayerRb.velocity = Vector2.up * Jumpf * 2;
        }
        
    }
}
