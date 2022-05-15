using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public List<GameObject> targets;
    public GameOver GameOverScreen;
    public Button restartButton;
    int maxPlatform = 0;
    public static GameControl instance;
    public bool gameOver = true;

    private int score = 0;
    public float scrollSpeed = -1.5f;


    void Awake()
    {

        if (instance == null)

            instance = this;

        else if (instance != this)

            Destroy(gameObject);
    }

    public void GameOver()
    {
        gameOver = true;
        restartButton.gameObject.SetActive(true);
        GameOverScreen.Setup(maxPlatform);
    }
}