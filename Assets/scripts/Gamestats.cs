using UnityEngine;
using System;

public class Gamestats : MonoBehaviour
{
   public static Gamestats Instance { get { return instance; } }
    private static Gamestats instance;
    // score 
    public float score;
    public float highscore;
    public float distanceModifer = 1.5f;
    //Fish
    public int totalFish;
    public int fishCollectedThisSession;
    public float pointPerFish;

    //Internal cooldown
    private float lastScoreUpdate;
    private float ScoreUpdateDelta = 0.2f;
    
    // Action 
    public Action<int> OnCollectFish;
    public Action<float> OnscoreChange;

    public void Update()
    {
        float s = GameManager.Instance.motor.transform.position.z * distanceModifer;
        s += fishCollectedThisSession * pointPerFish;

        if (s > score)
        {
             score = s;
            OnscoreChange?.Invoke(score);  // where costly we have to run it 60fps we have to call canvas every 60 sec
        }
          

    }

    public void CollectFish() 
    {
        fishCollectedThisSession++;
        OnCollectFish?.Invoke(fishCollectedThisSession);
    }


}
 