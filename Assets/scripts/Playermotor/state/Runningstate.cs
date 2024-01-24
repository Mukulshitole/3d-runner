using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runningstate : Basestate
{
    public override void Construct()
    {
        motor.verticalVelocity = 0;
    }

    public override Vector3 ProcessMotion()
    {
        Vector3 m = Vector3.zero;

        m.x = motor.SnapToLane();
        m.y = -1.0f; // is in air
        m.z = motor.baseRunspeed;  //speed
        return m;
    }

   
    public override void Transation()
    {
        if (InputManager.Instance.SwipeLeft)
        {
            // change lane go left
            motor.ChangeLane(-1);
        }
        if (InputManager.Instance.SwipeRight)
        {
            // change lane go right
            motor.ChangeLane(1);
        }
        if (InputManager.Instance.Swipeup  && motor.isGrounded)
        {
            // change lane go jump
            motor.changestate(GetComponent<Jumpingstate>());
        }
        if (!motor.isGrounded)
            motor.changestate(GetComponent<Fallingstate>());

        if (InputManager.Instance.Swipedown)
            motor.changestate(GetComponent<Slidingstate>());
    }
}
