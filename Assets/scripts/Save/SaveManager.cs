using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get { return instance; } }
    private static SaveManager instance;

    //Fields
    public Savestate save;
    private const string saveFilename = "data.ss"; // FUN PART you can save file name in any format .anything


    private void Awake()
    {
        Load();
        // Try and load the previous load state
    } 

    private void Load()
    {
        try
        { 
          FileStream file = new FileStream(saveFilename, FileMode.Open, FileAccess.Read);

        }
        catch
        {
            Debug.Log("save file not found let create a new one !"); //catch create safe files
        }
    }
}
