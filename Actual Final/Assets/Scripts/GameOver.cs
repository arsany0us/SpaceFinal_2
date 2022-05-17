using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip DeathSound;

    public Button restartButton;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound(DeathSound);
    }
    public void Setup(int score)
    { 

        restartButton.gameObject.SetActive(true);
        gameObject.SetActive(true);

    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
