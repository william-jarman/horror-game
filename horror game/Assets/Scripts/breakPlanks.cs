using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakPlanks : MonoBehaviour
{
    public GameObject plankNormal, planksBroken;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("axe"))
        {
            planksBroken.SetActive(true);
            plankNormal.SetActive(false);
        }
    }
}
