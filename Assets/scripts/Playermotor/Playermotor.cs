using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermotor : MonoBehaviour
{
    [HideInInspector] public Vector3 movevector;
    [HideInInspector] public float verticalVelocity;
    [HideInInspector] public bool isGrounded;
    [HideInInspector] public int currentLane; // -1 0 1

    public float distanceiInbetweenlanes = 3.0f;
    public float baseRunspeed = 5.0f;
    public float basesidewaspeed = 5.0f;
    public float gravity = 14.0f;
    public float terminalvelocity = 20.0f;

    public CharacterController controller;

    private Basestate state;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        state = GetComponent<Runningstate>();
        state.Construct();
    }

    private void Update()
    {
        updateMotor();
    }

    private void updateMotor()
    {
        // check if we`re grounded
        isGrounded = controller.isGrounded;

        // How should we be moving right now? based on state
        movevector = state.ProcessMotion();

        // Are we trying to change state?
        // means are we swipping up or down while walking 
        state.Transation();

        // move the player
        controller.Move(movevector * Time.deltaTime);

    }
     
    public void ChangeLane(int direction)
    {
        currentLane = Mathf.Clamp(currentLane + direction, -1, 1);
        // The purpose of Mathf.Clamp is to ensure that value falls within the
        // range defined by min and max. If value is less than min, it is set to min.
        // If value is greater than max, it is set to max.
        // If value is already within the specified range, it remains unchanged.
    }
    public void changestate(Basestate s)
    {
        state.Destruct();
        state = s;
        state.Construct();
    }
}
