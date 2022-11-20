using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLoop1 : MonoBehaviour
{
    //Number of loops.
    float loop;

    //Test objects.
    public GameObject testObj1, testObj2, testObj3, testObj4, testObj5, testObj6, testObj7;

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
            if(loopFixerScript.inTrigger == false)
            {
                loop = loop + 1;
            }
            if (loopFixerScript.inTrigger == true)
            {
                loop = loop - 1;
            }
            if (loop == 1)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(true);
                testObj3.SetActive(false);
                testObj4.SetActive(false);
                testObj5.SetActive(false);
                testObj6.SetActive(false);
                testObj7.SetActive(false);
            }
            if (loop == 2)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(false);
                testObj3.SetActive(true);
                testObj4.SetActive(false);
                testObj5.SetActive(false);
                testObj6.SetActive(false);
                testObj7.SetActive(false);
            }
            if (loop == 3)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(false);
                testObj3.SetActive(false);
                testObj4.SetActive(true);
                testObj5.SetActive(false);
                testObj6.SetActive(false);
                testObj7.SetActive(false);
            }
            if (loop == 4)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(false);
                testObj3.SetActive(false);
                testObj4.SetActive(false);
                testObj5.SetActive(true);
                testObj6.SetActive(false);
                testObj7.SetActive(false);
            }
            if (loop == 5)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(false);
                testObj3.SetActive(false);
                testObj4.SetActive(false);
                testObj5.SetActive(false);
                testObj6.SetActive(true);
                testObj7.SetActive(false);
            }
            if (loop == 6)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(false);
                testObj3.SetActive(false);
                testObj4.SetActive(false);
                testObj5.SetActive(false);
                testObj6.SetActive(false);
                testObj7.SetActive(true);
            }
            Debug.Log("Loop: " + loop);
        }
    }
}