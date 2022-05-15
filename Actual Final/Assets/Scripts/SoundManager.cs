using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public GameObject objectMusic;
    private AudioSource audioSrc;
    private float musicVolume = 1f;

    private void Start()
    {
        objectMusic = GameObject.FindWithTag("GameMusic");
        audioSrc = objectMusic.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (PauseMenu.GameIsPaused)
        {
            audioSrc.pitch *= .5f;
        }
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
