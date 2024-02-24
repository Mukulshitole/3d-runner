
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return instance; } }
    private static GameManager instance;
    public Playermotor motor;

    private Gamestate state;
    private void Awake()
    {
        instance = this;
        state = GetComponent<Gamestateinitilaiz>();
        state.Construct();
    } 

    private void Update()
    {
        state.UpdateState();
    }
    public void Changestate(Gamestate s)
    {
        state.Destruct();
        state = s;
        state.Construct();
    }

}
