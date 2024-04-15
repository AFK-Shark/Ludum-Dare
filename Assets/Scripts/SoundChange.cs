using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundChange : MonoBehaviour
{
    [SerializeField] private AudioMixer _music;
    private float _volume;
    private void Awake()
    {
        _music.GetFloat("MusicVol", out _volume);
        _music.SetFloat("MusicVol", -80);
    }
    private void OnDisable()
    {
        _music.SetFloat("MusicVol", _volume);
    }
}
