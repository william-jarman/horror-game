using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopScript : MonoBehaviour
{
    //Number of loops.
    float loop;

    //The objects.
    public GameObject ObjGroup1, ObjGroup2, ObjGroup3;

    //The trigger's collider.
    public Collider triggerCollider;

    public loopFixer loopFixerScript;

    //At the start of the scene, loop will be set to 0 and the trigger's collider will be disabled. The trigger's collider will be enabled at a trigger during the loop.
    void Start()
    {
        loop = 0;
    }

    //When the player enters the trigger, the loop counter will go up by 1 and depending on what loop is equal to, different objects will appear or disappear.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (loopFixerScript.inTrigger == false)
            {
                loop = loop + 1;
            }
            if (loopFixerScript.inTrigger == true)
            {
                loop = loop - 1;
            }
            if (loop < 0)
            {
                loop = 0;
            }
            if (loop == 0)
            {
                ObjGroup1.SetActive(true);
                ObjGroup2.SetActive(false);
                ObjGroup3.SetActive(false);
                ObjGroup4.SetActive(false);
            }
            if (loop == 1)
            {
                ObjGroup1.SetActive(false);
                ObjGroup2.SetActive(true);
                ObjGroup3.SetActive(false);
                ObjGroup4.SetActive(false);
            }
            if (loop == 2)
            {
                ObjGroup1.SetActive(false);
                ObjGroup2.SetActive(false);
                ObjGroup3.SetActive(true);
                ObjGroup4.SetActive(false);
            }
            if (loop == 3)
            {
                ObjGroup1.SetActive(false);
                ObjGroup2.SetActive(false);
                ObjGroup3.SetActive(false);
                ObjGroup4.SetActive(true);
            }
            Debug.Log("Loop: " + loop);
        }
    }
}