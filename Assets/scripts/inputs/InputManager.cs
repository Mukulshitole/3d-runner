 using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // there should be only one Inputmanager in the scence
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }

    // action schemas
    private RunnerInputAction actionScheme;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        SetupControl();
    }
    private void SetupControl()
    {
        actionScheme = new RunnerInputAction();

        // register different actions 
        actionScheme.Gameplay.Tap.performed += ctx => OnTap(ctx);
        actionScheme.Gameplay.TapPosition.performed += ctx => OnPosition(ctx);
        actionScheme.Gameplay.Startdrag.performed += ctx => OnStartdrag(ctx);
        actionScheme.Gameplay.Enddrag.performed += ctx => OnEnddrag(ctx);

    }

    private void OnEnddrag(InputAction.CallbackContext ctx)
    {
        throw new NotImplementedException();
    }

    private void OnStartdrag(InputAction.CallbackContext ctx)
    {
        throw new NotImplementedException();
    }

    private void OnPosition(InputAction.CallbackContext ctx)
    {
        throw new NotImplementedException();
    }

    private void OnTap(InputAction.CallbackContext ctx)
    {
        throw new NotImplementedException();
    }
}
 