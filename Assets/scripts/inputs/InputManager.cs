 using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // there should be only one Inputmanager in the scence
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }


    // action schemas
    private RunnerInputAction actionScheme;
    // configuration 
    [SerializeField] private float sqrSwipeDeadzone = 50.0f;

    #region public properties
    public bool Tap { get { return tap;} }
    public Vector2 TouchPosition { get { return touchposition; } }
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

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        SetupControl();
    }
    private void LateUpdate()
    {
        ResetInputs();
    }
    private void ResetInputs()
    {
        tap = swipedown = swipeLeft = swipeRight = swipeup = false;
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
        Vector2 delta = touchposition - startDrag;
        float sqrDistance = delta.sqrMagnitude;

        // Confirmed swipe
        if (sqrDistance > sqrSwipeDeadzone)
        {
            float x = Mathf.Abs(delta.x);
            float y = Mathf.Abs(delta.y);

            if (x > y) // Left or Right
            {
                if (delta.x > 0)
                    swipeRight = true;
                else
                    swipeLeft = true;
            }
            else // Up or Down
            {
                if (delta.y > 0)
                    swipeup = true;
                else
                    swipedown = true;
            }
        }

        startDrag = Vector2.zero;

    }
    private void OnStartdrag(InputAction.CallbackContext ctx)
    {
        startDrag = touchposition;
    }
    private void OnPosition(InputAction.CallbackContext ctx)
    {
        touchposition = ctx.ReadValue<Vector2>();
    }
    private void OnTap(InputAction.CallbackContext ctx)
    {
        tap = true;
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