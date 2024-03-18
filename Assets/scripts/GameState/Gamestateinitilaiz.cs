
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
         FishCountText.text = "Fish : " + "TBD";

        menuUI.SetActive(true);
    }
    public override void Destruct()
    {
        menuUI.SetActive(false);
    }
    public void OnPlayClick()
    {
        brain.Changestate(GetComponent<GamestateGame>());
        Gamestats.Instance.ResetSession();

    }

    public void OnShopClick() 
    {
        brain.Changestate(GetComponent<GamestateGame>());
    }

     
}
