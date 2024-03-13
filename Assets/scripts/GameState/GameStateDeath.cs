using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameStateDeath : Gamestate
{
    public GameObject deathUI;
    private float deathtime;
    [SerializeField] private TextMeshProUGUI  highscore;
    [SerializeField] private TextMeshProUGUI Currentscore;
    [SerializeField] private TextMeshProUGUI  Fishtotal;
    [SerializeField] private TextMeshProUGUI  currentFish;

    // completion circle fileds
    [SerializeField] private Image completionCircle;
    public float timetoDecision = 2.5f; // time to decide

    public override void Construct()
    {

        base.Construct();
        GameManager.Instance.motor.PausePlayer();

        deathtime = Time.time;
        deathUI.SetActive(true);
        completionCircle.gameObject.SetActive(true);
        highscore.text = "Highscore : TBD ";
        Currentscore.text = "?12345";  // question mark is put infront to know its temproary data
        Fishtotal.text = "Total :TBD ";
        currentFish.text = "x20";

    }
    public override void Destruct()
    {
        deathUI.SetActive(false);
    }
    public override void UpdateState()
    {
        //if (InputManager.Instance.Swipedown)
        //    ToMenu();
        //if (InputManager.Instance.Swipeup)
        //    ResumeGame();
        float ratio = (Time.time - deathtime) / timetoDecision;
        completionCircle.color = Color.Lerp(Color.green, Color.red, ratio);
        completionCircle.fillAmount = 1 - ratio;

        if (ratio > 1)
        {
            completionCircle.gameObject.SetActive(false);
        }

    }
    public void ResumeGame()
    {
       
        brain.Changestate(GetComponent<GamestateGame>());
        GameManager.Instance.motor.RespawnPlayer();
    }
    public void ToMenu()
    {
        brain.Changestate(GetComponent<Gamestateinitilaiz>());

        GameManager.Instance.motor.ResetPlayer();
        GameManager.Instance.worldgeneration.Resetworld();
    }
}
