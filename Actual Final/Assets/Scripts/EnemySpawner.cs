using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float respawnTime = 4.0f;
    private Vector2 screenBounds;
    public float spawnPosY = -3.75f;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());

    }
    private void spawnEnemy()
    {
        GameObject e = Instantiate(obstacle) as GameObject;
        e.transform.position = new Vector2(screenBounds.x, spawnPosY);
    }
    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
