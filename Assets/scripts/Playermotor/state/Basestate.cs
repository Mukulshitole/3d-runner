using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class Basestate : MonoBehaviour
{
    // abstract means you cant add this script to any object directly it needs a parent it wont work directly  
    protected Playermotor motor; 
    public virtual void Construct(){ } // once we enter a state eg: jump so set velocity to certain amount
    public virtual void Destruct(){ } // once we leave a state
    public virtual void Transation() { } // once we update a loop constantly for switching or transation btw diff state

    private void Awake()
    {
        motor = GetComponent<Playermotor>();

        if (motor == null)
        {
            Debug.LogError("Playermotor component not found on GameObject: " + gameObject.name);
        }
    }

    public virtual Vector3 ProcessMotion() 
    {
        Debug.Log("process motion is not implemented in" + this.ToString());
        return Vector3.zero;
    }

    
}
