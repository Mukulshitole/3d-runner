using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidingstate : Basestate
{
    public float slideduration = 1.0f;
    // collider logic 
    private Vector3 initalcenter;
    private float initialsize;
    private float slidestart;

    public override void Construct()
    {
        motor.anim?.SetTrigger("Slide");
        slidestart = Time.time;
        // as the player slides we have to reduce its collider height and 
        initialsize = motor.controller.height; 
        initalcenter = motor.controller.center;

        motor.controller.height = initialsize * 0.5f;
        motor.controller.center = initalcenter * 0.5f;
    }
    public override void Destruct()
    {
        motor.anim?.SetTrigger("Running");
        motor.controller.height = initialsize ;
        motor.controller.center = initalcenter ;
    }

    public override void Transation() // this function alllows player to change lane while sliding 
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
        if (!motor.isGrounded)
            motor.changestate(GetComponent<Fallingstate>());

        if (InputManager.Instance.Swipeup)
            motor.changestate(GetComponent<Jumpingstate>());
        if (Time.time - slidestart > slideduration)
            motor.changestate(GetComponent<Runningstate>());
       
    }

    public override Vector3 ProcessMotion()
    {
        Vector3 m = Vector3.zero;

        m.x = motor.SnapToLane();
        m.y = -1.0f; // is in air
        m.z = motor.baseRunspeed;  //speed
        return m;
    }
}
