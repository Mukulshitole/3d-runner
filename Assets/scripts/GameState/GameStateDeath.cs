﻿using System.Collections;
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
       
        brain.Changestate(GetComponent<GamestateGame>());
        GameManager.Instance.motor.RespawnPlayer();
    }
    public void ToMenu()
    {
        brain.Changestate(GetComponent<Gamestateinitilaiz>());
        GameManager.Instance.motor.transform.position = Vector3.zero;
        GameManager.Instance.motor.anim?.SetTrigger("Idle");
        GameManager.Instance.motor.changestate(GameManager.Instance.motor.GetComponent<Runningstate>());
    }
}
