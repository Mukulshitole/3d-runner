
using System;

[System.Serializable]
public class Savestate 
{
    public int Highscore { set; get; }
    public int Fish { set; get; }
    public DateTime LastSaveTime { set; get; }

    public Savestate()
    {
        Highscore = 0;
        Fish = 0;
        LastSaveTime = DateTime.Now;
    }
}
