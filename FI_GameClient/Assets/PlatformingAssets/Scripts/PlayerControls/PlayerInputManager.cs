using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private FPS_ControlActions controls;
    public Vector2 move;
    public bool jumped = false;

    public static PlayerInputManager _instance;

    public static PlayerInputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        controls = new FPS_ControlActions();

        Cursor.visible = false;
        controls.Keyboard.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Keyboard.Movement.canceled += ctx => move = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Keyboard.Enable();
    }
    private void OnDisable()
    {
        controls.Keyboard.Disable();
    }

    public bool PlayerJumpedThisFrame()
    {
        return controls.Keyboard.Jump.triggered;
    }
}
