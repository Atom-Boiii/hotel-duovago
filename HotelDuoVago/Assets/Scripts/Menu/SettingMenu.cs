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

    public void Start()
    {
        SetMasterVolume(volumeSliderMaster.value);
        SetSFXVolume(volumeSliderSFX.value);
        SetMusicVolume(volumeSliderSFX.value);
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("Master Volume", volume);
        textMaster.text = Mathf.Round(volume) + volumeBalancer + "%";
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFX Volume", volume);
        textSFX.text = Mathf.Round(volume) + volumeBalancer + "%";
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Music Volume", volume);
        textMusic.text = Mathf.Round(volume) + volumeBalancer + "%";
    }
}
