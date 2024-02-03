
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
         
    }

    public void Destruct()
    {

    }
    public virtual void UpdateStatet()
    {

    }
}
