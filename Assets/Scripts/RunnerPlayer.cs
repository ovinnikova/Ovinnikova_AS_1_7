//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/Scripts/RunnerPlayer.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @RunnerPlayer : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @RunnerPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RunnerPlayer"",
    ""maps"": [
        {
            ""name"": ""Runner"",
            ""id"": ""8597f962-ec43-4b8b-97c4-8e661e56714c"",
            ""actions"": [
                {
                    ""name"": ""SideMove"",
                    ""type"": ""Value"",
                    ""id"": ""7fa52f32-9b3f-46c6-80ad-b10622a6b411"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""967214fd-cdb6-49da-a1b3-6a100a117679"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""23c8303f-5eb0-4af9-a324-53fb02260558"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""cd37267c-f089-4089-abdb-f734814e8cdd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7d6c1218-853c-48ef-9775-356af44ba39f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""20eadd8e-a5c2-4794-9e4a-b74fea9c4187"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e6c770ab-6874-4b4f-9a5a-d2c3be3bda3e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9838b2f-cc3c-423a-a5a4-7f858d6d3ff2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""346d5d89-1601-488f-8a15-9f798a2caff1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Runner
        m_Runner = asset.FindActionMap("Runner", throwIfNotFound: true);
        m_Runner_SideMove = m_Runner.FindAction("SideMove", throwIfNotFound: true);
        m_Runner_Jump = m_Runner.FindAction("Jump", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Runner
    private readonly InputActionMap m_Runner;
    private IRunnerActions m_RunnerActionsCallbackInterface;
    private readonly InputAction m_Runner_SideMove;
    private readonly InputAction m_Runner_Jump;
    public struct RunnerActions
    {
        private @RunnerPlayer m_Wrapper;
        public RunnerActions(@RunnerPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @SideMove => m_Wrapper.m_Runner_SideMove;
        public InputAction @Jump => m_Wrapper.m_Runner_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Runner; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RunnerActions set) { return set.Get(); }
        public void SetCallbacks(IRunnerActions instance)
        {
            if (m_Wrapper.m_RunnerActionsCallbackInterface != null)
            {
                @SideMove.started -= m_Wrapper.m_RunnerActionsCallbackInterface.OnSideMove;
                @SideMove.performed -= m_Wrapper.m_RunnerActionsCallbackInterface.OnSideMove;
                @SideMove.canceled -= m_Wrapper.m_RunnerActionsCallbackInterface.OnSideMove;
                @Jump.started -= m_Wrapper.m_RunnerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_RunnerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_RunnerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_RunnerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SideMove.started += instance.OnSideMove;
                @SideMove.performed += instance.OnSideMove;
                @SideMove.canceled += instance.OnSideMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public RunnerActions @Runner => new RunnerActions(this);
    public interface IRunnerActions
    {
        void OnSideMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
