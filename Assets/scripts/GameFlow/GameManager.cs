
using UnityEngine;
public enum GameCamera
{
    Init =0,
    Game=1,
    Shop =3,
    Respawn=2

}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return instance; } }
    private static GameManager instance;
    public Playermotor motor;
    public GameObject[] cameras;

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

    public void ChangeCamera(GameCamera c)
    {
        foreach (GameObject go in cameras)
            go.SetActive(false);

        cameras[(int)c].SetActive(true);
    }

}
