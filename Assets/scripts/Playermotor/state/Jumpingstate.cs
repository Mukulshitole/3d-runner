using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpingstate : Basestate
{
    public float jumpForce = 7.0f;
    public override void Construct()
    {
        motor.verticalVelocity = jumpForce;
        motor.anim?.SetTrigger("Jump");
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
        if (motor.verticalVelocity < 0)
        {
            motor.changestate(GetComponent<Fallingstate>());
        }
    }
}
