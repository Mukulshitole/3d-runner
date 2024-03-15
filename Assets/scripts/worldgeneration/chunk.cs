using UnityEngine;

public class chunk : MonoBehaviour
{
    public float chunklength;

    public chunk Showchunk()
    {
        transform.gameObject.BroadcastMessage("OnShowChunk", SendMessageOptions.DontRequireReceiver);
        gameObject.SetActive(true);
        return this;
     
    }
    public chunk hidechunk()
    {
        gameObject.SetActive(false);
        return this;
    }
  
}
