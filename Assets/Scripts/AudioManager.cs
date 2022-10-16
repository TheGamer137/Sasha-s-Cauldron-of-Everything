using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class VolumeControl
{
    public string Name;
    public float Volume = 1f;
    public float TempVolume = 1f;
}
public class AudioManager : MonoBehaviour
{
    //[SerializeField] private Profiles _profile;
    [SerializeField] private Slider _music;
    [SerializeField] private Toggle _soundEffect;
    [SerializeField] private AudioSource _mainMusic, _onClickSound;
    
    void Start()
    {
        bool toggleIsOn = false;
        if(PlayerPrefs.GetInt("toggleIsOn") == 1)
        {
            toggleIsOn = true;
            _onClickSound.volume = 0;
        }
        else
        {
            toggleIsOn = false;
            _onClickSound.volume = 1;
        }
        _soundEffect.isOn = toggleIsOn;
        _music.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    // Update is called once per frame
    void Update()
    {
        _mainMusic.volume = _music.value;
        if (Input.GetMouseButtonDown(0))
        {
            _onClickSound.Play();
        }
        
    }

    public void VolumePrefs()
    {
        PlayerPrefs.SetFloat("MusicVolume", _mainMusic.volume);
        if(_soundEffect.isOn)
        {
            PlayerPrefs.SetInt("toggleIsOn", 1);
            _onClickSound.volume = 0;
        }
        else
        {
            PlayerPrefs.SetInt("toggleIsOn", 0);
            _onClickSound.volume = 1;
        }
        if (Input.GetMouseButtonDown(0))
        {
            _onClickSound.Play();
        }
    }
}
