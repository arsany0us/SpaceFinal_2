using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randY;
    float randX;
    Vector2 whereToSpawnY;
    public float spawnRate = 10f;
    float nextSpawn = 0.0f;
    private float minValueX = -3.75f;
    private float minValueY = -3.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(5f, 5f);
            whereToSpawnY = new Vector2(randY, transform.position.x);

            Instantiate(enemy, whereToSpawnY, Quaternion.identity);
        }
        
    }
}
