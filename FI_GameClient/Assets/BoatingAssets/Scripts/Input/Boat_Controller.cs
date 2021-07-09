using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_Controller : MonoBehaviour
{

    private Boat_InputActions controls;
    public BoomDirectionHandler boomDirection;
    public BoatDirectionHandler boatDirection;
    public WindDirector windDirector;

    public float rudderDirection;
    public float sailTension;
    bool holdingTension = false;


    private void Awake()
    {
        controls = new Boat_InputActions();

        controls.Boat_Keyboard.Rudder.performed += ctx => rudderDirection = ctx.ReadValue<float>();
        controls.Boat_Keyboard.Rudder.canceled += ctx => rudderDirection = 0;

        //controls.Boat_Keyboard.SailTension.performed += ctx => sailTension = ctx.ReadValue<float>();
        controls.Boat_Keyboard.StartTension.performed += ctx => holdingTension = true;
        controls.Boat_Keyboard.StartTension.canceled += ctx => holdingTension = false;

        controls.Boat_Keyboard.SailTension.performed += ctx => TensionChange(ctx.ReadValue<float>());
        controls.Boat_Keyboard.SailTension.canceled += ctx => sailTension = 0;

        controls.Boat_Keyboard.GenerateGlobalWind.performed += ctx => WindChange();
    }

    private void OnEnable()
    {
        controls.Boat_Keyboard.Enable();

    }
    private void OnDisable()
    {
        controls.Boat_Keyboard.Disable();
    }

    void WindChange()
    {
        windDirector.GenerateWind();
        boomDirection.UpdateWindData();
    }

    void TensionChange(float inputTension)
    {
        if (holdingTension)
        {
            Debug.Log("TENSION");
        }
        sailTension = inputTension;
    }
}
