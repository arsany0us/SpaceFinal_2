using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameOver GameOverScreen;
    int maxPlatform = 0;
    public static GameControl instance;

    private int score = 0;
    public bool gameOver = false;
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

        GameOverScreen.Setup(maxPlatform);
    }
}