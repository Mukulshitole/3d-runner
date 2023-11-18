 using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // there should be only one Inputmanager in the scence
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }

    

    #region public properties
    private bool Tap { get { return tap;} }
    public Vector2 TouchPosition { get { return TouchPosition; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight{ get { return swipeRight; } }
    public bool Swipeup{ get { return swipeup; } }
    public bool Swipedown{ get { return swipedown; } }
    #endregion

    #region privates
    private bool tap;
    
    private Vector2 touchposition;
    private Vector2 startDrag;
    private bool swipeLeft;
    private bool swipeRight;
    private bool swipeup;
    private bool swipedown;
    #endregion

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

    public void OnEnable()
    {
        actionScheme.Enable();
    }
    public void OnDisable()
    {
        actionScheme.Disable();
    }
}
  /* 
   *    DYNAMIC UPDATE
   *    inputmanager that processess the inputs
   * 
   *    LATE UPDATE
   *    Inputmanager resets these inputs 
   */