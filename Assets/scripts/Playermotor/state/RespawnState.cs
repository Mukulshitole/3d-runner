using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnState : Basestate
{
    [SerializeField] private float verticaldistance = 25.0f;
    [SerializeField] private float immunityTime = 1f;

    private float startTime;
    public override void Construct()
    {
        startTime = Time.time;
        motor.controller.enabled = false;
        motor.transform.position = new Vector3(0, verticaldistance, motor.transform.position.z);
        motor.controller.enabled = true;

        motor.verticalVelocity = 0.0f;
        motor.currentLane = 0;
        motor.anim?.SetTrigger("Respawn");
    }
    public override Vector3 ProcessMotion()
    {
        // Apply gravity 
        motor.ApplyGravity();
         // create our return vector 

        Vector3 m = Vector3.zero;

        m.x = motor.SnapToLane();
        m.y = -1.0f; // is in air
        m.z = motor.baseRunspeed;  //speed
        return m;
    }
    public override void Transation()
    {
        if (motor.isGrounded && (Time.time - startTime)> immunityTime) // from here we can pull a transation
            motor.changestate(GetComponent<Runningstate>());  

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
    }


}
