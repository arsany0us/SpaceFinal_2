using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip DeadSound;

    public Text pointsText;
    public Button restartButton;
    public void Setup(int score)
    { 
        audioSource = GetComponent<AudioSource>();
        PlaySound(DeadSound);
        restartButton.gameObject.SetActive(true);
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
