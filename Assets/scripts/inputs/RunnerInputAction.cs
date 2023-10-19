// GENERATED AUTOMATICALLY FROM 'Assets/scripts/inputs/RunnerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RunnerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @RunnerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""RunnerInputAction"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b3ffff76-fc5f-4413-ace5-2d68fb38be9d"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""06deb2fb-5fe3-49a2-89f8-e21328e29f13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TapPosition"",
                    ""type"": ""Value"",
                    ""id"": ""81d51bf0-a8ca-469b-a563-41c92d1d7253"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Startdrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""25611a71-20a2-4bc0-b52b-48757424ad53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Enddrag"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e0a70f23-c1ee-4e2f-a236-73c4b74e5afd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""36adb6a3-fb44-4ee2-9ed6-b861b4f9ffa8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac66e35f-defa-45e8-b0da-54fd634ad600"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1f67b72-47fc-4068-aee7-4636d92eed99"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""TapPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5803e8b7-89e9-4cf8-b3e6-af7d4fd8add5"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""TapPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fdee15c-8e68-42b8-afae-c59901f4178c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Startdrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""839c72b2-242a-49a9-8990-4b314256c446"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Startdrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d7b0c03-cc37-4f38-a9a7-70641a69203a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Enddrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46887a30-a37b-40db-9ba1-881fe9f8615b"",
                    ""path"": ""<Touchscreen>/touch*/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mobile"",
                    ""action"": ""Enddrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Computer"",
            ""bindingGroup"": ""Computer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Tap = m_Gameplay.FindAction("Tap", throwIfNotFound: true);
        m_Gameplay_TapPosition = m_Gameplay.FindAction("TapPosition", throwIfNotFound: true);
        m_Gameplay_Startdrag = m_Gameplay.FindAction("Startdrag", throwIfNotFound: true);
        m_Gameplay_Enddrag = m_Gameplay.FindAction("Enddrag", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Tap;
    private readonly InputAction m_Gameplay_TapPosition;
    private readonly InputAction m_Gameplay_Startdrag;
    private readonly InputAction m_Gameplay_Enddrag;
    public struct GameplayActions
    {
        private @RunnerInputAction m_Wrapper;
        public GameplayActions(@RunnerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_Gameplay_Tap;
        public InputAction @TapPosition => m_Wrapper.m_Gameplay_TapPosition;
        public InputAction @Startdrag => m_Wrapper.m_Gameplay_Startdrag;
        public InputAction @Enddrag => m_Wrapper.m_Gameplay_Enddrag;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTap;
                @TapPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTapPosition;
                @TapPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTapPosition;
                @TapPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTapPosition;
                @Startdrag.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartdrag;
                @Startdrag.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartdrag;
                @Startdrag.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartdrag;
                @Enddrag.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnddrag;
                @Enddrag.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnddrag;
                @Enddrag.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEnddrag;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @TapPosition.started += instance.OnTapPosition;
                @TapPosition.performed += instance.OnTapPosition;
                @TapPosition.canceled += instance.OnTapPosition;
                @Startdrag.started += instance.OnStartdrag;
                @Startdrag.performed += instance.OnStartdrag;
                @Startdrag.canceled += instance.OnStartdrag;
                @Enddrag.started += instance.OnEnddrag;
                @Enddrag.performed += instance.OnEnddrag;
                @Enddrag.canceled += instance.OnEnddrag;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_ComputerSchemeIndex = -1;
    public InputControlScheme ComputerScheme
    {
        get
        {
            if (m_ComputerSchemeIndex == -1) m_ComputerSchemeIndex = asset.FindControlSchemeIndex("Computer");
            return asset.controlSchemes[m_ComputerSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnTap(InputAction.CallbackContext context);
        void OnTapPosition(InputAction.CallbackContext context);
        void OnStartdrag(InputAction.CallbackContext context);
        void OnEnddrag(InputAction.CallbackContext context);
    }
}
