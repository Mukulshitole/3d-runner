using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingstate : Basestate
{
    public override void Construct()
    {
        motor.anim?.SetTrigger("Fall");
    }
    public override Vector3 ProcessMotion()
    {
        // apply gravity 
        motor.ApplyGravity();

        // create our return vector
        Vector3 m = Vector3.zero;

        m.x = motor.SnapToLane();
        m.y = motor.verticalVelocity;
        m.z = motor.baseRunspeed;  //speed
        return m;
    }
    public override void Transation()
    {
        if (motor.isGrounded)
            motor.changestate(GetComponent<Runningstate>());

    }
}
