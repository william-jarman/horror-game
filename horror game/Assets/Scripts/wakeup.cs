using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wakeup : MonoBehaviour
{
    public GameObject playerObj, wakeupCam;
    public float wakeupTime;

    void Start()
    {
        StartCoroutine(wakeupEvent());
    }
    IEnumerator wakeupEvent()
    {
        yield return new WaitForSeconds(wakeupTime);
        wakeupCam.SetActive(false);
        playerObj.SetActive(true);
    }
}
