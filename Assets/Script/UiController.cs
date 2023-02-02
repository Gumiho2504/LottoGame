using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Slider musicSlider, sfxSlider;
   
    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }
    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }
    public void MusicVolume()
    {
        AudioManager.instance.MusicVolume(musicSlider.value);
    }
    public void SFXVolume()
    {
        AudioManager.instance.MusicVolume(sfxSlider.value);
    }
}
