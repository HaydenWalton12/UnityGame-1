using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSoundManager : MonoBehaviour
{
    public static AudioSource AudioSources;
    private void Start()
    {
        AudioSources = GetComponent<AudioSource>();
    }
    public static void PlaySoundEffect(AudioClip PlaySound)
    {
        AudioSources.PlayOneShot(PlaySound, 1f);
    }

}
