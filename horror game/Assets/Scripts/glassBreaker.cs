using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassBreaker : MonoBehaviour
{
    //public Animator glassAnim, glassBreakerAnim;
    public GameObject intText, glassBreakerHand;
    public bool interactable, toggle;
    public float breakTime, afterBreakTime;
    public itemPickup axeScript;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == false)
            {
                if (glassBreakerHand.active == true)
                {
                    intText.SetActive(true);
                    interactable = true;
                }
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //glassBreakerAnim.SetTrigger("hit");
                StartCoroutine(breakGlass());
                intText.SetActive(false);
                toggle = true;
                interactable = false;
            }
        }
    }
    IEnumerator breakGlass()
    {
        yield return new WaitForSeconds(breakTime);
        //glassAnim.SetTrigger("break");
        yield return new WaitForSeconds(afterBreakTime);
        glassBreakerHand.SetActive(false);
        axeScript.toggle = true;
    }
}