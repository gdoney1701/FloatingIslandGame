using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_Controller : MonoBehaviour
{

    private Boat_InputActions controls;
    public float rudderDirection;
    public float sailTension;
    public WindDirector windDirector;

    private void Awake()
    {
        controls = new Boat_InputActions();
        controls.Boat_Keyboard.Rudder.performed += ctx => rudderDirection = ctx.ReadValue<float>();
        controls.Boat_Keyboard.SailTension.performed += ctx => sailTension = ctx.ReadValue<float>();
        controls.Boat_Keyboard.GenerateGlobalWind.performed += ctx => windDirector.GenerateWind();
    }

    private void OnEnable()
    {
        controls.Boat_Keyboard.Enable();

    }
    private void OnDisable()
    {
        controls.Boat_Keyboard.Disable();
    }
}
