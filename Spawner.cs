using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemyPrefab;
    public Transform topBorder;
    public Transform lowerBorder;

    public float spawnInterval;
    public float spawnTimer;

    public int spawnCount;

    // Update is called once per frame
    void Update()
    {

        if (spawnTimer > 0)
        {
        spawnTimer -= Time.deltaTime;

        }
        else
        {
            Spawn();
        }

    }
    public void Spawn()
    {
        spawnTimer = spawnInterval;

        Vector3 position = transform.position;
        float randomY = Random.Range(lowerBorder.position.y, topBorder.position.y);
        position.y = randomY;
        Enemy enemy = Instantiate(enemyPrefab, position, Quaternion.identity);

    }
}
