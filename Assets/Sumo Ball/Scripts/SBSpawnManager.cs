using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBSpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<SBEnemy>().Length;

        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float SpawnPosX = Random.Range(-spawnRange , spawnRange);
        float SpawnPosZ = Random.Range(-spawnRange , spawnRange);
        Vector3 randomPos = new Vector3(SpawnPosX, 0 , SpawnPosZ);
        return randomPos;
    }
}
