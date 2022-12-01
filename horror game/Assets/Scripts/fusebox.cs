using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusebox : MonoBehaviour
{
    public Animator fuseboxAnim;
    public GameObject mainLights, PCMonitor, intText, dialogueText;
    public bool interactable, toggle;
    public float timeToTurnOn, dialogueTime;

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
                fuseboxAnim.SetTrigger("toggle");
                StartCoroutine(turnOnFusebox());
                intText.SetActive(false);
                toggle = true;
                interactable = false;
            }
        }
    }
    IEnumerator turnOnFusebox()
    {
        yield return new WaitForSeconds(timeToTurnOn);
        mainLights.SetActive(true);
        PCMonitor.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        dialogueText.SetActive(true);
        yield return new WaitForSeconds(dialogueTime);
        dialogueText.SetActive(false);
    }
}