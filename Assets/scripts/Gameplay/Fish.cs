using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PickupFish();
    }

    private void PickupFish()
    {
        anim?.SetTrigger("Pickup");
        // Increment the fish counter
        Gamestats.Instance.CollectFish();
        // INcrement the score
        // play sfx
        // trigger a animation 
    }

    public void OnShowChunk()
    {
        anim?.SetTrigger("Idle");
    }
}
