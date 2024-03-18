using UnityEngine;
using TMPro;
public class GamestateGame : Gamestate
{
    public GameObject gameui;
    [SerializeField] private TextMeshProUGUI fishcount;
    [SerializeField] private TextMeshProUGUI Scorecount;
    public override void Construct()
    {
        base.Construct();
        GameManager.Instance.motor.ResumePlayer();
        GameManager.Instance.ChangeCamera(GameCamera.Game);

        Gamestats.Instance.OnCollectFish += OnCollectFish;
        Gamestats.Instance.OnscoreChange += OnScoreChange;

       
        //7hr 48min

        gameui.SetActive(true);
    }
    private void OnCollectFish(int amnCollected)
    {
        fishcount.text = Gamestats.Instance.FishToText();
       
    }

    private void OnScoreChange(float score)
    {
        Scorecount.text = Gamestats.Instance.ScoreToText();
    }
    public override void Destruct()
    {
        gameui.SetActive(false);
        Gamestats.Instance.OnCollectFish -= OnCollectFish;
        Gamestats.Instance.OnscoreChange -= OnScoreChange;

    }


    public override void UpdateState()
    {
        GameManager.Instance.worldgeneration.scanposition();
        GameManager.Instance.ScenceChunkGeneration.scanposition();
    }

  
}