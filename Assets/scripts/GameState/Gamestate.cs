
using UnityEngine;

public abstract class Gamestate : MonoBehaviour
{
    protected GameManager brain;
    private void Awake()
    {
        brain = GetComponent<GameManager>(); 
    }
    public virtual void Construct()
    {
        Debug.Log("constructing :" + this.ToString());
    }

    public virtual void Destruct()
    {

    }
    public virtual void UpdateState()
    {

    }
}
