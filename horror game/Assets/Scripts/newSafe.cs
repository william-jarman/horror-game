using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class newSafe : MonoBehaviour
{
    public Transform safeDial;
    public int correctSafeCode;
    public Animator safeAnimator;
    public GameObject player, safeCamera, intText;
    public bool usingSafe, interactable, toggle;
    public string currentSafeCode;
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
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                safeDial.rotation = Quaternion.Euler(-15, 90, 90);
                currentSafeCode = currentSafeCode + "1";
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                safeDial.rotation = Quaternion.Euler(-30, 90, 90);
                currentSafeCode = currentSafeCode + "2";
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                safeDial.rotation = Quaternion.Euler(-45, 90, 90);
                currentSafeCode = currentSafeCode + "3";
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, 60, safeDial.position.z));
                currentSafeCode = currentSafeCode + "4";
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, 75, safeDial.position.z));
                currentSafeCode = currentSafeCode + "5";
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, safeDial.position.y, safeDial.position.z));
                currentSafeCode = currentSafeCode + "6";
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, safeDial.position.y, safeDial.position.z));
                currentSafeCode = currentSafeCode + "7";
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, safeDial.position.y, safeDial.position.z));
                currentSafeCode = currentSafeCode + "8";
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, safeDial.position.y, safeDial.position.z));
                currentSafeCode = currentSafeCode + "9";
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                safeDial.LookAt(new Vector3(safeDial.position.x, safeDial.position.y, safeDial.position.z));
                currentSafeCode = currentSafeCode + "0";
            }
            safeCodeText.text = currentSafeCode;
            string safeCodeString = currentSafeCode;
            int safeInt = Convert.ToInt32(safeCodeString);
            if(safeInt == correctSafeCode)
            {
                safeCamera.SetActive(false);
                player.SetActive(true);
                usingSafe = true;
                safeAnimator.SetTrigger("open");
            }
        }
    }
}
