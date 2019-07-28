using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float xPositionLimit;

    public float SpawnRate;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnSpicke();
        StartSpawing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSpicke()
    {
       float randomX = Random.Range(-xPositionLimit, xPositionLimit);

        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
     void StartSpawing()
    {
        InvokeRepeating("SpawnSpicke", 1f, SpawnRate);
    }

    public void StopSpawing()
    {
        CancelInvoke("SpawnSpicke");
    }


}
