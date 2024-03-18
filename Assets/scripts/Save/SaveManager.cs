
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get { return instance; } }
    private static SaveManager instance;

    //Fields
    private const string saveFilename = "data.ss"; // FUN PART you can save file name in any format .anything
}
