using UnityEngine;

public class Deathstate : Basestate
{
    [SerializeField] private Vector3 knockbackForce = new Vector3(0, 4, -3);
    public override void Construct()
    {
        //gamemanager.instance.changestate(gamemanager.instance.getcomponent<gamestatedeath>());
    }
    //public override Vector3 ProcessMotion()
    //{
    //    Debug.Log("DEATH");
    //    return base.ProcessMotion();

    //}

    public override Vector3  ProcessMotion()
    {
        Vector3 m = knockbackForce;

        knockbackForce = new Vector3(0, knockbackForce.y -= motor.gravity * Time.deltaTime,
            knockbackForce.z += 2.0f * Time.deltaTime);

        m.x = motor.SnapToLane();
        m.y = -1.0f;
        m.z = motor.baseRunspeed;
        m.z = motor.baseRunspeed;
        return m;

    }
}
