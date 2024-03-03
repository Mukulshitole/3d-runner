
using UnityEngine;

public class Gamestateinitilaiz : Gamestate
{
    public override void Construct()
    {
        GameManager.Instance.ChangeCamera(GameCamera.Init);
    }

    public override void UpdateState()
    {
        if (InputManager.Instance.Tap)
            brain.Changestate(GetComponent<GamestateGame>());
    }
}
