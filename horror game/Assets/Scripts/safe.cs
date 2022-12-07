using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe : MonoBehaviour
{
    public Transform safeDial;
    public Animator handleTurn, safeAnim;
    public string handleAnimationName;
    public int dialTurns1, dialTurns2, dialTurns3;
    public SC_FPSController playerscript;
    public float rotationAmount;
    int currentTurn;
    public itemPickup key;
    public bool lock1, lock2, lock3, done, interactable, usingSafe;
    public GameObject playerCam, safeCam, intText;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if(done == false)
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
    void Start()
    {
        currentTurn = 0;
        lock1 = true;
        lock2 = true;
        lock3 = true;
    }

    void Update()
    {
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                safeCam.SetActive(true);
                intText.SetActive(false);
                playerscript.enabled = false;
                usingSafe = true;
                playerCam.SetActive(false);
                interactable = false;
            }
        }
        if(usingSafe == true)
        {
            //Handle turn
            if (Input.GetKeyDown(KeyCode.E))
            {
                handleTurn.Play(handleAnimationName);
                if (lock1 == false)
                {
                    if (lock2 == false)
                    {
                        if (lock3 == false)
                        {
                            done = true;
                            safeCam.SetActive(false);
                            key.toggle = true;
                            playerscript.enabled = true;
                            playerCam.SetActive(true);
                            safeAnim.SetTrigger("open");
                            usingSafe = false;
                        }
                    }
                }
                else
                {
                    lock1 = true;
                    lock2 = true;
                    lock3 = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                safeCam.SetActive(false);
                playerCam.SetActive(true);
                playerscript.enabled = true;
                usingSafe = false;
            }
            //Turning dial left
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine("rotateLeft");
            }
            if (Input.GetMouseButtonUp(0))
            {
                StopCoroutine("rotateLeft");
                if (lock1 == true)
                {
                    if (currentTurn == dialTurns1)
                    {
                        lock1 = false;
                    }
                }
                if (lock1 == false)
                {
                    if (lock2 == true)
                    {
                        if (currentTurn == dialTurns2)
                        {
                            lock2 = false;
                        }
                    }
                }
                if (lock2 == false)
                {
                    if (lock3 == true)
                    {
                        if (currentTurn == dialTurns3)
                        {
                            lock3 = false;
                        }
                    }
                }
                currentTurn = 0;
            }
            //Turning dial right
            if (Input.GetMouseButtonDown(1))
            {
                StartCoroutine("rotateRight");
            }
            if (Input.GetMouseButtonUp(1))
            {
                StopCoroutine("rotateRight");
                if (lock1 == true)
                {
                    if (currentTurn == dialTurns1)
                    {
                        lock1 = false;
                    }
                }
                if (lock1 == false)
                {
                    if (lock2 == true)
                    {
                        if (currentTurn == dialTurns2)
                        {
                            lock2 = false;
                        }
                    }
                }
                if (lock2 == false)
                {
                    if (lock3 == true)
                    {
                        if (currentTurn == dialTurns3)
                        {
                            lock3 = false;
                        }
                    }
                }
                currentTurn = 0;
            }
        }
    }
    IEnumerator rotateLeft()
    {
        yield return new WaitForSeconds(0.5f);
        safeDial.Rotate(0, 0, -rotationAmount * Time.deltaTime);
        currentTurn = currentTurn - 1;
    }
    IEnumerator rotateRight()
    {
        yield return new WaitForSeconds(0.5f);
        safeDial.Rotate(0, 0, rotationAmount * Time.deltaTime);
        currentTurn = currentTurn + 1;
    }
}