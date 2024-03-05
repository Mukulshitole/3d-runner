
public class GamestateGame: Gamestate
{
  
  
    public override void Construct()
    {
        base.Construct();
        GameManager.Instance.motor.ResumePlayer();
        GameManager.Instance.ChangeCamera(GameCamera.Game);
    }

    public override void UpdateState()
    {
        GameManager.Instance.worldgeneration.scanposition();
        GameManager.Instance.ScenceChunkGeneration.scanposition();
    }
} 