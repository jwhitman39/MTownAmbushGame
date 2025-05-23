//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.12.0
//     from Assets/PlayerControls.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/PlayerControls.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""01271f19-846f-4396-b47c-6edf297ff73f"",
            ""actions"": [
                {
                    ""name"": ""PressA"",
                    ""type"": ""Button"",
                    ""id"": ""8fa81748-cd79-4927-b150-42b692368a2d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressB"",
                    ""type"": ""Button"",
                    ""id"": ""0108c2d8-1167-4383-a705-333ecaaa0fdc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressY"",
                    ""type"": ""Button"",
                    ""id"": ""1d900360-6caa-4110-ac72-4540945483ba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressX"",
                    ""type"": ""Button"",
                    ""id"": ""f80eb373-11f2-4dca-a635-e9e42e782609"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressL"",
                    ""type"": ""Button"",
                    ""id"": ""2f8be74d-669e-4a82-9ac8-03a797c7e1ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressR"",
                    ""type"": ""Button"",
                    ""id"": ""4a48c295-af75-4c97-9384-715f91fea456"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressZL"",
                    ""type"": ""Button"",
                    ""id"": ""05a938b8-97c9-48f9-91ae-6507dcd3ad87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressZR"",
                    ""type"": ""Button"",
                    ""id"": ""9e13bb10-ef95-4cb3-a7f5-8e0e40c08c73"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressLS"",
                    ""type"": ""Button"",
                    ""id"": ""a5610de7-c91a-47be-ad93-5b1507629fe5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PressRS"",
                    ""type"": ""Button"",
                    ""id"": ""a3155bb1-2b9e-4b84-9914-e3abf85a904a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33b3b64f-be60-465a-925c-eb80dc133647"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b75185e5-0b99-41db-af9a-825af162e4c1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9196e47b-b257-481d-a4cf-0609f56c9ff5"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65192300-930d-45a4-913f-2972f9395a51"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb3b0bcf-060c-438f-af26-d9d321049739"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e692ae0-a5e7-495c-8afb-7bb6c540ea01"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25d27722-6d69-4693-8f3c-63ff518a7915"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressZL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5f64e5e-a9a3-423d-b5c7-d4011ed6f384"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressZR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""571822cf-a5cf-4238-a4aa-701a7b1dfcfb"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressLS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e10bf033-3df7-4923-a453-48a6832e2385"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressRS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_PressA = m_Gameplay.FindAction("PressA", throwIfNotFound: true);
        m_Gameplay_PressB = m_Gameplay.FindAction("PressB", throwIfNotFound: true);
        m_Gameplay_PressY = m_Gameplay.FindAction("PressY", throwIfNotFound: true);
        m_Gameplay_PressX = m_Gameplay.FindAction("PressX", throwIfNotFound: true);
        m_Gameplay_PressL = m_Gameplay.FindAction("PressL", throwIfNotFound: true);
        m_Gameplay_PressR = m_Gameplay.FindAction("PressR", throwIfNotFound: true);
        m_Gameplay_PressZL = m_Gameplay.FindAction("PressZL", throwIfNotFound: true);
        m_Gameplay_PressZR = m_Gameplay.FindAction("PressZR", throwIfNotFound: true);
        m_Gameplay_PressLS = m_Gameplay.FindAction("PressLS", throwIfNotFound: true);
        m_Gameplay_PressRS = m_Gameplay.FindAction("PressRS", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Gameplay.enabled, "This will cause a leak and performance issues, PlayerControls.Gameplay.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_PressA;
    private readonly InputAction m_Gameplay_PressB;
    private readonly InputAction m_Gameplay_PressY;
    private readonly InputAction m_Gameplay_PressX;
    private readonly InputAction m_Gameplay_PressL;
    private readonly InputAction m_Gameplay_PressR;
    private readonly InputAction m_Gameplay_PressZL;
    private readonly InputAction m_Gameplay_PressZR;
    private readonly InputAction m_Gameplay_PressLS;
    private readonly InputAction m_Gameplay_PressRS;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gameplay".
    /// </summary>
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressA".
        /// </summary>
        public InputAction @PressA => m_Wrapper.m_Gameplay_PressA;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressB".
        /// </summary>
        public InputAction @PressB => m_Wrapper.m_Gameplay_PressB;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressY".
        /// </summary>
        public InputAction @PressY => m_Wrapper.m_Gameplay_PressY;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressX".
        /// </summary>
        public InputAction @PressX => m_Wrapper.m_Gameplay_PressX;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressL".
        /// </summary>
        public InputAction @PressL => m_Wrapper.m_Gameplay_PressL;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressR".
        /// </summary>
        public InputAction @PressR => m_Wrapper.m_Gameplay_PressR;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressZL".
        /// </summary>
        public InputAction @PressZL => m_Wrapper.m_Gameplay_PressZL;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressZR".
        /// </summary>
        public InputAction @PressZR => m_Wrapper.m_Gameplay_PressZR;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressLS".
        /// </summary>
        public InputAction @PressLS => m_Wrapper.m_Gameplay_PressLS;
        /// <summary>
        /// Provides access to the underlying input action "Gameplay/PressRS".
        /// </summary>
        public InputAction @PressRS => m_Wrapper.m_Gameplay_PressRS;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GameplayActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @PressA.started += instance.OnPressA;
            @PressA.performed += instance.OnPressA;
            @PressA.canceled += instance.OnPressA;
            @PressB.started += instance.OnPressB;
            @PressB.performed += instance.OnPressB;
            @PressB.canceled += instance.OnPressB;
            @PressY.started += instance.OnPressY;
            @PressY.performed += instance.OnPressY;
            @PressY.canceled += instance.OnPressY;
            @PressX.started += instance.OnPressX;
            @PressX.performed += instance.OnPressX;
            @PressX.canceled += instance.OnPressX;
            @PressL.started += instance.OnPressL;
            @PressL.performed += instance.OnPressL;
            @PressL.canceled += instance.OnPressL;
            @PressR.started += instance.OnPressR;
            @PressR.performed += instance.OnPressR;
            @PressR.canceled += instance.OnPressR;
            @PressZL.started += instance.OnPressZL;
            @PressZL.performed += instance.OnPressZL;
            @PressZL.canceled += instance.OnPressZL;
            @PressZR.started += instance.OnPressZR;
            @PressZR.performed += instance.OnPressZR;
            @PressZR.canceled += instance.OnPressZR;
            @PressLS.started += instance.OnPressLS;
            @PressLS.performed += instance.OnPressLS;
            @PressLS.canceled += instance.OnPressLS;
            @PressRS.started += instance.OnPressRS;
            @PressRS.performed += instance.OnPressRS;
            @PressRS.canceled += instance.OnPressRS;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GameplayActions" />
        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @PressA.started -= instance.OnPressA;
            @PressA.performed -= instance.OnPressA;
            @PressA.canceled -= instance.OnPressA;
            @PressB.started -= instance.OnPressB;
            @PressB.performed -= instance.OnPressB;
            @PressB.canceled -= instance.OnPressB;
            @PressY.started -= instance.OnPressY;
            @PressY.performed -= instance.OnPressY;
            @PressY.canceled -= instance.OnPressY;
            @PressX.started -= instance.OnPressX;
            @PressX.performed -= instance.OnPressX;
            @PressX.canceled -= instance.OnPressX;
            @PressL.started -= instance.OnPressL;
            @PressL.performed -= instance.OnPressL;
            @PressL.canceled -= instance.OnPressL;
            @PressR.started -= instance.OnPressR;
            @PressR.performed -= instance.OnPressR;
            @PressR.canceled -= instance.OnPressR;
            @PressZL.started -= instance.OnPressZL;
            @PressZL.performed -= instance.OnPressZL;
            @PressZL.canceled -= instance.OnPressZL;
            @PressZR.started -= instance.OnPressZR;
            @PressZR.performed -= instance.OnPressZR;
            @PressZR.canceled -= instance.OnPressZR;
            @PressLS.started -= instance.OnPressLS;
            @PressLS.performed -= instance.OnPressLS;
            @PressLS.canceled -= instance.OnPressLS;
            @PressRS.started -= instance.OnPressRS;
            @PressRS.performed -= instance.OnPressRS;
            @PressRS.canceled -= instance.OnPressRS;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />.
        /// </summary>
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
        /// <seealso cref="GameplayActions.UnregisterCallbacks(IGameplayActions)" />
        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GameplayActions" /> instance referencing this action map.
    /// </summary>
    public GameplayActions @Gameplay => new GameplayActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gameplay" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GameplayActions.AddCallbacks(IGameplayActions)" />
    /// <seealso cref="GameplayActions.RemoveCallbacks(IGameplayActions)" />
    public interface IGameplayActions
    {
        /// <summary>
        /// Method invoked when associated input action "PressA" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressA(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressB" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressB(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressY" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressY(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressX" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressX(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressL" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressL(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressR" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressR(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressZL" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressZL(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressZR" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressZR(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressLS" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressLS(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "PressRS" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnPressRS(InputAction.CallbackContext context);
    }
}
