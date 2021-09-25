using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class IngameMenu : MonoBehaviour
{
    public GameObject ingameMenu;

    public SettingMenu settingMenu;

    public TextMeshProUGUI textMaster;
    public TextMeshProUGUI textSFX;
    public TextMeshProUGUI textMusic;
    public Slider volumeSliderMaster;
    public Slider volumeSliderSFX;
    public Slider volumeSliderMusic;

    //Toggling the Menu.

    public void IngameMenuToggle()
    {
        ingameMenu.SetActive(true);

        GetComponent<MenuScreenChange>().Pause();
    }

    public void ActivateToggle()
    {

    }

    public void TestActivateToggle()
    {
        IngameMenuToggle();
    }

    //Options Menu

    public void SetMasterVolume()
    {
        settingMenu.SetMasterVolume(volumeSliderMaster.value);
    }

    public void SetSFXVolume()
    {
        settingMenu.SetSFXVolume(volumeSliderSFX.value);
    }

    public void SetMusicVolume()
    {
        settingMenu.SetMusicVolume(volumeSliderMusic.value);
    }
}
