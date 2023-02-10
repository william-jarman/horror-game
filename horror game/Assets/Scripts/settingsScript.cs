using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsScript : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        if (PlayerPrefs.HasKey("playedBefore"))
        {

        }
        else if(!PlayerPrefs.HasKey("playedBefore"))
        {
            PlayerPrefs.SetInt("playedBefore", 0);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.GetInt("playedBefore", 0 ) == 0)
        {
            PlayerPrefs.SetFloat("masterVolume", 1f);
            PlayerPrefs.SetInt("playedBefore", 1);
            PlayerPrefs.Save();
        }
        AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");
        volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }
    public void volumeChange()
    {
        PlayerPrefs.SetFloat("masterVolume", volumeSlider.value);
        AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");
        PlayerPrefs.Save();
        Debug.Log(AudioListener.volume.ToString());
    }
}
