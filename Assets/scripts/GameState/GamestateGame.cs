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

        fishcount.text = "xTBD";
        Scorecount.text = "xTBD";
        //7hr 48min

        gameui.SetActive(true);
    }
    public override void Destruct()
    {
        gameui.SetActive(false);
    }


    public override void UpdateState()
    {
        GameManager.Instance.worldgeneration.scanposition();
        GameManager.Instance.ScenceChunkGeneration.scanposition();
    }
}