using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakPlanks : MonoBehaviour
{
    public GameObject plankNormal, planksBroken, axe;
    public bool interactable;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(axe.active == true)
            {
                interactable = true;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = true;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                plankNormal.SetActive(false);
                planksBroken.SetActive(true);
            }
        }
    }
}
