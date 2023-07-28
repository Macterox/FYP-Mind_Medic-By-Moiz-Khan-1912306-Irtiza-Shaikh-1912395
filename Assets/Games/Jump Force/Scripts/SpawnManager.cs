using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);
    public float StartDelay = 2;
    public float repeatRate = 2f;
    private PlayerController PlayerCS;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCS = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle",StartDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(PlayerCS.gameOver == false){
        Instantiate(ObstaclePrefab, spawnPos, ObstaclePrefab.transform.rotation);
        }
    }
}
