﻿
public class GamestateGame: Gamestate
{
    public override void Construct()
    {
        base.Construct();
        GameManager.Instance.motor.ResumePlayer();
    }
}
