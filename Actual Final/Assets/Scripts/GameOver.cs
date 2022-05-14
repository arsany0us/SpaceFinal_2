using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text pointsText;
    public Button restartButton;
    public GameObject titleScreen;
    public void Setup(int score)
    {
        restartButton.gameObject.SetActive(true);
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "POINTS";
        RestartButton();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        titleScreen.gameObject.SetActive(false);

    }
}
