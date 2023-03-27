using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer ButtonMixer;

    public void SetVolume (float volume1)
    {
        audioMixer.SetFloat("volume", volume1);
        Debug.Log(volume1);
    }

    public void SetButtonVolume(float volume2)
    {
        ButtonMixer.SetFloat("volume2", volume2);
        Debug.Log(volume2);
    }
}
