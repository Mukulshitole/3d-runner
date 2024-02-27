using UnityEngine;

public class Deathstate : Basestate
{
    [SerializeField] private Vector3 knockbackForce = new Vector3(0, 4, -3);
    public override void Construct()
    {
        motor.anim?.SetTrigger("Death");
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

        if(knockbackForce.z>0)
        {
            knockbackForce.z = 0;
            GameManager.Instance.Changestate(GameManager.Instance.GetComponent<GameStateDeath>());
        }

     
        return knockbackForce;

    }
}
