using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingMenu : MonoBehaviour
{
    public IngameMenu ingameMenu;

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
        ingameMenu.textMaster.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderMaster.value = volume;
        ingameMenu.volumeSliderMaster.value = volume;
    }

    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFX Volume", volume);
        textSFX.text = Mathf.Round(volume) + volumeBalancer + "%";
        ingameMenu.textSFX.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderSFX.value = volume;
        ingameMenu.volumeSliderSFX.value = volume;
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Music Volume", volume);
        textMusic.text = Mathf.Round(volume) + volumeBalancer + "%";
        ingameMenu.textMusic.text = Mathf.Round(volume) + volumeBalancer + "%";
        volumeSliderMusic.value = volume;
        ingameMenu.volumeSliderMusic.value = volume;
    }

    public void SetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
}
