using UnityEngine;

public class snowfloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Material material;
    public float offsetspeed = 0.2f;
    private void Update()
    {
        transform.position = Vector3.forward * player.transform.position.z;
        material.SetVector("Vector2_DAD7764F", new Vector2(0,-transform.position.z* offsetspeed));
    }
}
