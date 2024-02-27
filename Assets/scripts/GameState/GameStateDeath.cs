using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateDeath : Gamestate
{
    public override void Construct()
    {
        base.Construct();
        GameManager.Instance.motor.PausePlayer();
    }
    public override void UpdateState()
    {
        if (InputManager.Instance.Swipedown)
            ToMenu();
        if (InputManager.Instance.Swipeup)
            ResumeGame();

    }
    public void ResumeGame()
    {
        GameManager.Instance.motor.RespawnPlayer();
        brain.Changestate(GetComponent<GamestateGame>());
    }
    public void ToMenu()
    {
        brain.Changestate(GetComponent<Gamestateinitilaiz>());
    }
}
