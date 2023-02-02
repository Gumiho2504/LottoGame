using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource,sfxSource;
    public Button music, sfs;
    public Sprite musicMuteButtonSprite, sfxMuteButtonsprite, musicButtonSprite, sfxButtonsprite;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //PlayMusic("hmm");
    }
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.soundname == name);

        if(s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.soundname == name);

        if (s == null)
        {
            Debug.Log("Sound Efect Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
        if (sfxSource.mute)
        {
            sfs.image.sprite = sfxMuteButtonsprite;
        }else if (!sfxSource.mute)
        {
            sfs.image.sprite=  sfxButtonsprite;
        }
    }
    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
        if (musicSource.mute)
        {
            music.image.sprite = musicMuteButtonSprite;
        }
        else if (!musicSource.mute)
        {
            music.image.sprite = musicButtonSprite;
        }
    }
    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

}
