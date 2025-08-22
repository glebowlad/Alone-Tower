using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        if (volume <= 0.0001f)
            volume = 0.0001f;
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume)*20);
    }
}
