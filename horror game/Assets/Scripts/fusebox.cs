using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fusebox : MonoBehaviour
{
    public Animator fuseboxAnim;
    public GameObject mainLights, intText, dialogueText, box, monitorPrompt;
    public bool interactable, toggle;
    public Text dialogueTextt;
    public string dialogueString;
    public float timeToTurnOn, dialogueTime;
    public itemPickup fuseToFind;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == false)
            {
                if (fuseToFind.pickedup == true)
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
        monitorPrompt.SetActive(false);
        box.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        dialogueText.SetActive(true);
        dialogueTextt.text = dialogueString;
        yield return new WaitForSeconds(dialogueTime);
        dialogueText.SetActive(false);
    }
}