
public class GamestateGame: Gamestate
{
    public override void Construct()
    {
        GameManager.Instance.motor.ResumePlayer();
    }
}
