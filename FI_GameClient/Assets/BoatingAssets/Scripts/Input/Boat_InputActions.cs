// GENERATED AUTOMATICALLY FROM 'Assets/BoatingAssets/Scripts/Input/Boat_InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Boat_InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Boat_InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Boat_InputActions"",
    ""maps"": [
        {
            ""name"": ""Boat_Keyboard"",
            ""id"": ""55a3e781-24d5-428b-825c-ac7eb8965544"",
            ""actions"": [
                {
                    ""name"": ""Rudder"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d65ee7a9-4e6a-4a70-8c5c-7fbda52e3ed6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SailTension"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e5c802e0-616c-4e98-97ee-a1e2a566a0cb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchSides"",
                    ""type"": ""Value"",
                    ""id"": ""c32562d9-ad25-4350-906b-988a8d6417c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bc084548-5937-4856-8416-d1e87aca004d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GenerateGlobalWind"",
                    ""type"": ""Button"",
                    ""id"": ""1f8adebb-8a81-470f-be19-e3d3b29aa367"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartTension"",
                    ""type"": ""Button"",
                    ""id"": ""650bafae-e0c1-43ef-9cfd-33e148c36459"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD_Steering"",
                    ""id"": ""93571e3e-6ebd-40cd-b321-e8a83cf9417c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41be5fcb-150d-40ac-91c9-cb97ee102d66"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""40021911-2428-4c13-9ac8-f6c3dd744570"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rudder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1d9b2ac6-9437-4b23-9164-322f2b5f39f8"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SailTension"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""QE_Sides"",
                    ""id"": ""bb60be60-0aac-49a3-a568-5e704ba42a48"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchSides"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""33744251-19c2-474b-9758-43923030cfb8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchSides"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b0e974da-b6d4-4f21-8185-0cc499852fcd"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchSides"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a5f1dc61-0571-4cdb-8ab8-0e5cc44cd3fd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c1b7bc-1d39-4fbe-8108-358fd4643f12"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GenerateGlobalWind"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96499fd7-ec45-437f-be3d-2c3583db7359"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartTension"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Boat_Keyboard
        m_Boat_Keyboard = asset.FindActionMap("Boat_Keyboard", throwIfNotFound: true);
        m_Boat_Keyboard_Rudder = m_Boat_Keyboard.FindAction("Rudder", throwIfNotFound: true);
        m_Boat_Keyboard_SailTension = m_Boat_Keyboard.FindAction("SailTension", throwIfNotFound: true);
        m_Boat_Keyboard_SwitchSides = m_Boat_Keyboard.FindAction("SwitchSides", throwIfNotFound: true);
        m_Boat_Keyboard_Look = m_Boat_Keyboard.FindAction("Look", throwIfNotFound: true);
        m_Boat_Keyboard_GenerateGlobalWind = m_Boat_Keyboard.FindAction("GenerateGlobalWind", throwIfNotFound: true);
        m_Boat_Keyboard_StartTension = m_Boat_Keyboard.FindAction("StartTension", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Boat_Keyboard
    private readonly InputActionMap m_Boat_Keyboard;
    private IBoat_KeyboardActions m_Boat_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Boat_Keyboard_Rudder;
    private readonly InputAction m_Boat_Keyboard_SailTension;
    private readonly InputAction m_Boat_Keyboard_SwitchSides;
    private readonly InputAction m_Boat_Keyboard_Look;
    private readonly InputAction m_Boat_Keyboard_GenerateGlobalWind;
    private readonly InputAction m_Boat_Keyboard_StartTension;
    public struct Boat_KeyboardActions
    {
        private @Boat_InputActions m_Wrapper;
        public Boat_KeyboardActions(@Boat_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rudder => m_Wrapper.m_Boat_Keyboard_Rudder;
        public InputAction @SailTension => m_Wrapper.m_Boat_Keyboard_SailTension;
        public InputAction @SwitchSides => m_Wrapper.m_Boat_Keyboard_SwitchSides;
        public InputAction @Look => m_Wrapper.m_Boat_Keyboard_Look;
        public InputAction @GenerateGlobalWind => m_Wrapper.m_Boat_Keyboard_GenerateGlobalWind;
        public InputAction @StartTension => m_Wrapper.m_Boat_Keyboard_StartTension;
        public InputActionMap Get() { return m_Wrapper.m_Boat_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Boat_KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IBoat_KeyboardActions instance)
        {
            if (m_Wrapper.m_Boat_KeyboardActionsCallbackInterface != null)
            {
                @Rudder.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnRudder;
                @Rudder.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnRudder;
                @Rudder.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnRudder;
                @SailTension.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSailTension;
                @SailTension.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSailTension;
                @SailTension.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSailTension;
                @SwitchSides.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSwitchSides;
                @SwitchSides.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSwitchSides;
                @SwitchSides.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnSwitchSides;
                @Look.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnLook;
                @GenerateGlobalWind.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnGenerateGlobalWind;
                @GenerateGlobalWind.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnGenerateGlobalWind;
                @GenerateGlobalWind.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnGenerateGlobalWind;
                @StartTension.started -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnStartTension;
                @StartTension.performed -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnStartTension;
                @StartTension.canceled -= m_Wrapper.m_Boat_KeyboardActionsCallbackInterface.OnStartTension;
            }
            m_Wrapper.m_Boat_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rudder.started += instance.OnRudder;
                @Rudder.performed += instance.OnRudder;
                @Rudder.canceled += instance.OnRudder;
                @SailTension.started += instance.OnSailTension;
                @SailTension.performed += instance.OnSailTension;
                @SailTension.canceled += instance.OnSailTension;
                @SwitchSides.started += instance.OnSwitchSides;
                @SwitchSides.performed += instance.OnSwitchSides;
                @SwitchSides.canceled += instance.OnSwitchSides;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @GenerateGlobalWind.started += instance.OnGenerateGlobalWind;
                @GenerateGlobalWind.performed += instance.OnGenerateGlobalWind;
                @GenerateGlobalWind.canceled += instance.OnGenerateGlobalWind;
                @StartTension.started += instance.OnStartTension;
                @StartTension.performed += instance.OnStartTension;
                @StartTension.canceled += instance.OnStartTension;
            }
        }
    }
    public Boat_KeyboardActions @Boat_Keyboard => new Boat_KeyboardActions(this);
    public interface IBoat_KeyboardActions
    {
        void OnRudder(InputAction.CallbackContext context);
        void OnSailTension(InputAction.CallbackContext context);
        void OnSwitchSides(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnGenerateGlobalWind(InputAction.CallbackContext context);
        void OnStartTension(InputAction.CallbackContext context);
    }
}
