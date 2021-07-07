using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private FPS_ControlActions playerControls;

    private void Awake()
    {
        playerControls = new FPS_ControlActions();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Keyboard.Movement.ReadValue<Vector2>();
    }
    public Vector2 GetMouseDelta()
    {
        return playerControls.Keyboard.Look.ReadValue<Vector2>();
    }
    public bool PlayerJumped()
    {
        return playerControls.Keyboard.Jump.triggered;
    }
}
