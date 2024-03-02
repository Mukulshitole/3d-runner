using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnState : Basestate
{
    [SerializeField] private float verticaldistance = 25.0f;
    public override void Construct()
    {
        motor.controller.enabled = false;
        motor.transform.position = new Vector3(0, verticaldistance, motor.transform.position.z);
        motor.controller.enabled = true;
    }
}
