using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableLoopTrigger : MonoBehaviour
{
    //The loop trigger's collider.
    public Collider triggerCollider;
    
    //When the player enters the trigger, the loop trigger's collider will be enabled for the next loop.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerCollider.enabled = true;
        }
    }
}