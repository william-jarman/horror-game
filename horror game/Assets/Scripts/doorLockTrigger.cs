using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorLockTrigger : MonoBehaviour
{
    public door doorScript;
    public Animator doorAnim;
    public Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("close");
            doorScript.locked = true;
            collision.enabled = false;
        }
    }
}
