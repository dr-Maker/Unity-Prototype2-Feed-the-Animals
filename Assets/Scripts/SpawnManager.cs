using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public int animalIndex;
    public float spawnRangeX = 19f;
    public float spawnPosZ;

    [Range(2,5)]
    public float startDelay;
    [Range(0.01f, 3)]
    public float spawninterval;


    private void Start()
    {

        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawninterval);

    }

    

    private void SpawnRandomAnimal()
    {

        animalIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(enemies[animalIndex], spawnPos, this.enemies[animalIndex].transform.rotation);

    }
}
