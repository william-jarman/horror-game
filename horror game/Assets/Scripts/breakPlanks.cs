using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakPlanks : MonoBehaviour
{
    public GameObject plankNormal, planksBroken, axe;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(axe.active == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    planksBroken.SetActive(true);
                    plankNormal.SetActive(false);
                }
            }
        }
    }
}
