using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TextMeshProUGUI textMaster;
    public TextMeshProUGUI textSFX;
    public TextMeshProUGUI textMusic;
    public Slider volumeSliderMaster;
    public Slider volumeSliderSFX;
    public Slider volumeSliderMusic;

    public float volumeBalancer;

    public void Awake()
    {
        textMaster.text = Mathf.Round(PlayerPrefs.GetFloat("Master Volume")) + volumeBalancer + "%";
        textSFX.text = Mathf.Round(PlayerPrefs.GetFloat("SFX Volume")) + volumeBalancer + "%";
        textMusic.text = Mathf.Round(PlayerPrefs.GetFloat("Music Volume")) + volumeBalancer + "%";
        volumeSliderMaster.value = PlayerPrefs.GetFloat("Master Volume");
        volumeSliderSFX.value = PlayerPrefs.GetFloat("SFX Volume");
        volumeSliderMusic.value = PlayerPrefs.GetFloat("Music Volume");
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("Master Volume", volume);
        textMaster.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderMaster.value = volume;

        PlayerPrefs.SetFloat("Master Volume", volume);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFX Volume", volume);
        textSFX.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderSFX.value = volume;
        
        PlayerPrefs.SetFloat("SFX Volume", volume);
        PlayerPrefs.Save();
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Music Volume", volume);
        textMusic.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderMusic.value = volume;

        PlayerPrefs.SetFloat("Music Volume", volume);
        PlayerPrefs.Save();
    }

    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
}
