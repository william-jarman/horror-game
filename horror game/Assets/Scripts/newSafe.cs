using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class newSafe : MonoBehaviour
{
    public Transform safeDial;
    public Animator safeAnimator;
    public GameObject player, safeCamera, intText;
    public bool usingSafe, interactable, toggle;
    public string currentSafeCode, correctSafeCode;
    public TextMeshProUGUI safeCodeText;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(toggle == true)
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
        Debug.Log(currentSafeCode);
        if(usingSafe == false)
        {
            if (interactable == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    safeCamera.SetActive(true);
                    intText.SetActive(false);
                    player.SetActive(false);
                    usingSafe = true;
                    interactable = false;
                }
            }
        }
        if(usingSafe == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                safeCamera.SetActive(false);
                currentSafeCode = "";
                player.SetActive(true);
                usingSafe = false;
                interactable = false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                safeDial.rotation = Quaternion.Euler(-40, 90, 90);
                currentSafeCode = currentSafeCode + "1";
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                safeDial.rotation = Quaternion.Euler(-80, 90, 90);
                currentSafeCode = currentSafeCode + "2";
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                safeDial.rotation = Quaternion.Euler(-120, 90, 90);
                currentSafeCode = currentSafeCode + "3";
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                safeDial.rotation = Quaternion.Euler(-160, 90, 90);
                currentSafeCode = currentSafeCode + "4";
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                safeDial.rotation = Quaternion.Euler(-200, 90, 90);
                currentSafeCode = currentSafeCode + "5";
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                safeDial.rotation = Quaternion.Euler(-240, 90, 90);
                currentSafeCode = currentSafeCode + "6";
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                safeDial.rotation = Quaternion.Euler(-280, 90, 90);
                currentSafeCode = currentSafeCode + "7";
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                safeDial.rotation = Quaternion.Euler(-310, 90, 90);
                currentSafeCode = currentSafeCode + "8";
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                safeDial.rotation = Quaternion.Euler(-340, 90, 90);
                currentSafeCode = currentSafeCode + "9";
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                safeDial.rotation = Quaternion.Euler(-360, 90, 90);
                currentSafeCode = currentSafeCode + "0";
            }
            safeCodeText.text = currentSafeCode;
            if (currentSafeCode.Contains(correctSafeCode))
            {
                safeCamera.SetActive(false);
                player.SetActive(true);
                usingSafe = true;
                toggle = false;
                safeAnimator.SetTrigger("open");
            }
        }
    }
}
