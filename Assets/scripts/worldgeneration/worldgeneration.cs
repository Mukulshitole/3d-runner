using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldgeneration : MonoBehaviour
{
    // gameplay 
    private float Chunkspawnz;
    private Queue<chunk> activechunks = new Queue<chunk>();
    private List<chunk> ChunkPool = new List<chunk>();

    // configurable fields 
    [SerializeField] private int firsstchunkSpawnposition = -10 ;
    [SerializeField] private int chunkonScreen = 5; // how many chunks do we have to show on screen it depends on performance and also optimzition 
    [SerializeField] private float despawnDistance = 5.0f;

    [SerializeField] private List<GameObject> chunkprefab;
    [SerializeField] private Transform cameraTransform;

    private void Awake()
    {
        Resetworld();
    }
    private void Start()
    {
        // check if we have an empty chunk prefab list 
        if (chunkprefab.Count == 0)
        {
            Debug.LogError("no chunk prefab found on the world generator,please assign some chunks");
            return;
        }
        // try to assign a cameratransform
        if (!cameraTransform)
        {
            cameraTransform = Camera.main.transform;
            Debug.Log("we assigned cameratrasnform automatically to the camera.main");
        }
    }

    
    void Update()
    {
        scanposition();
    }
    public void scanposition()
    {
        // if our camera goes beyond a certain point then we spawn new chunk 
        float cameraZ = cameraTransform.position.z;
        chunk lastChunk = activechunks.Peek();
        // what is Peek?
        // in DSA if we have to acess last variable in a queue we can use two methods
        //[activechunks.count-1]so it returns last stored variable in the queue and tells the activate
        // if the object is active or not  
        // or simple use PEEK() it acess last variable info and return
        if (cameraZ >= lastChunk.transform.position.z+lastChunk.chunklength+despawnDistance) 
        { 
            spawnNewchunk();
            DeletelastChunk();
        }
    }
    private void spawnNewchunk()
    {
        // get a random index for which prefab to spawn from 0 to last prefab select a random chunk
        int randomIndex = Random.Range(0, chunkprefab.Count);

        // does already exist in the pool same shouldnt be repated check availablity 
        chunk chunk = ChunkPool.Find(x => !x.gameObject.activeSelf && x.name == (chunkprefab[randomIndex].name+"(Clone)"));
        //create a chunk if we are not able to find one to reuse
        if (!chunk)
        {
            GameObject go = Instantiate(chunkprefab[randomIndex], transform); //The Instantiate function allows you to create multiple copies of a prefab during runtime, which can be very useful for creating numerous similar objects, such as enemies, bullets, or any other game elements.
            chunk = go.GetComponent<chunk>();
        }

        //place the object and show it 
        chunk.transform.position = new Vector3(0, 0, Chunkspawnz);
        Chunkspawnz += chunk.chunklength;

        // store the value to reuse the pool
        activechunks.Enqueue(chunk); // checks which is active chunk and which is not
        chunk.Showchunk();

    }

    private void DeletelastChunk()
    {
        chunk chunk = activechunks.Dequeue(); // removes the oldest chunk from list 
        chunk.hidechunk();
        ChunkPool.Add(chunk);
    }
    public void Resetworld()
    {
        // reset the chunkspawnz 
        Chunkspawnz = firsstchunkSpawnposition;
        for (int i = activechunks.Count; i != 0; i--)
            DeletelastChunk();
        for (int i = 0; i < chunkonScreen; i++)
            spawnNewchunk();

    }
}    
