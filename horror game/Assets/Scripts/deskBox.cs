using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deskBox : MonoBehaviour
{
    public Animator boxAnim;
    public GameObject intText, monitorPrompt, fuse3;
    public bool interactable, toggle, locked;
    public itemPickup glassBreakerScript;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == false)
            {
                intText.SetActive(true);
                interactable = true;
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
                if(locked == true && fuse3.active == true)
                {
                    monitorPrompt.SetActive(true);
                }
                if(locked == false)
                {
                    boxAnim.SetTrigger("open");
                    monitorPrompt.SetActive(false);
                    glassBreakerScript.toggle = true;
                    intText.SetActive(false);
                    toggle = true;
                    interactable = false;
                }
            }
        }
    }
}