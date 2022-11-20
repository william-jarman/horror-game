using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopFixer : MonoBehaviour
{
    public bool inTrigger;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
}