using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] musicClips, soundClips;
    public AudioSource musicSourceObj, soundSourceObj;
    public void PlayMusic(int a)
    {
        musicSourceObj.clip = musicClips[a];
        musicSourceObj.Play();
    }
    public void PlaySound(int a)
    {
        soundSourceObj.clip = soundClips[a];
        soundSourceObj.Play();
    }
}
