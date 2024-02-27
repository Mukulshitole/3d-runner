
using UnityEngine;

public class Gamestateinitilaiz : Gamestate
{
  
    public override void UpdateState()
    {
        if (InputManager.Instance.Tap)
            brain.Changestate(GetComponent<GamestateGame>());
    }
}
