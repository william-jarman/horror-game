using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLoop : MonoBehaviour
{
    //Number of loops.
    float loop;

    //Test objects.
    public GameObject testObj1, testObj2, testObj3;

    //The trigger's collider.
    public Collider triggerCollider;

    //At the start of the scene, loop will be set to 0 and the trigger's collider will be disabled. The trigger's collider will be enabled at a trigger during the loop.
    void Start()
    {
        loop = 0;
        triggerCollider.enabled = false;
    }
    
    //When the player enters the trigger, the loop counter will go up by 1 and depending on what loop is equal to, different objects will appear or disappear.
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loop = loop + 1;
            if(loop == 1)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(true);
            }
            if (loop == 2)
            {
                testObj2.SetActive(false);
                testObj3.SetActive(true);
            }
            if (loop == 3)
            {
                testObj3.SetActive(false);
                testObj1.SetActive(true);
            }
            if (loop == 4)
            {
                testObj1.SetActive(false);
                testObj2.SetActive(true);
            }
            triggerCollider.enabled = false;
        }
    }
    //After entering the trigger, the trigger's collider will be disabled to avoid problems and will be re-enabled by another trigger on the next loop.
}