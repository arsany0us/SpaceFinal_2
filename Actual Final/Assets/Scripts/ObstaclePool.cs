using UnityEngine;

public class ObstaclePool : MonoBehaviour
{
    public GameObject columnPrefab;
    public int columnPoolSize = 5;
    public float spawnRate = 2f;
    public float enemyMin = 0f;
    public float enemyMax = 10f;                                    //Maximum y value of the column position.

    private GameObject[] columns;                                    //Collection of pooled columns.
    private int currentColumn = 0;                                    //Index of the current column in the collection.

    private Vector2 objectPoolPosition = new Vector2(-15, -25);        //A holding position for our unused columns offscreen.
    private float spawnXPosition = 3f;

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;


        columns = new GameObject[columnPoolSize];

        for (int i = 0; i < columnPoolSize; i++)
        {

            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }



    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;


            float spawnYPosition = Random.Range(enemyMin, enemyMax);


            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);


            currentColumn++;

            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}