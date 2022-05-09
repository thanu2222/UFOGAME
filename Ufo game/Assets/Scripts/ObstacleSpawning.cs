using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    // This variable will contain obstacles that are going to spawn
    public GameObject obstacle;
    // This variable will make the obstacles spawn within this range
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    // This variable will dictate how much time will be taken to spawn the next variable
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        // Checking the time passsed is greater the spawn time
        if(Time.time > spawnTime)
        {
            // Calling the spawn fucntion when its greater 
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;

        }
    }

    void Spawn()
    {
        // This will allow the obstacles to not spawn on the same posistion 
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        // Spawning a new obeject
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
