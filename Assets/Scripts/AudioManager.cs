using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonBase<AudioManager>
{
    public AudioSource AudioSourceUI;
    
  

    [Range(0,1)] public float VolumeUI,VolumeBackground, VolumeWin,VolumeLose;

    private void Start()
    {
    }
    public void PLayAudioUI()
    {
        AudioSourceUI.volume = VolumeUI;
        AudioSourceUI.Play();
    }
    
}
