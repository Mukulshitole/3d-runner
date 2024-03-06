
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gamestateinitilaiz : Gamestate
{

    public GameObject menuUI;
    [SerializeField] private TextMeshProUGUI HighScoreText;
    [SerializeField] private TextMeshProUGUI FishCountText;
    public override void Construct()
    {
        GameManager.Instance.ChangeCamera(GameCamera.Init);
        HighScoreText.text = "HighScore : " + "TBD";
    }
   public void OnPlayClick()
   {
        brain.Changestate(GetComponent<GamestateGame>());

    }

    public void OnShopClick() 
    {
        brain.Changestate(GetComponent<GamestateGame>());
    }
}
