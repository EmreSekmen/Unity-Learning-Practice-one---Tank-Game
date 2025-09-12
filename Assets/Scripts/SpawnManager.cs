using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyprefabs;
    public GameObject[] airplanespawn;
    private float spawnrange = 7f;
    private float spawnPosz = 68f, SpawnPosz2 = 80;
    private float startTime = 1f, RepeatTime = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawn", startTime, RepeatTime);
        InvokeRepeating("AirPlaneSpawn", 5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void EnemySpawn()
    {

        Vector3 spawnpos = new Vector3(UnityEngine.Random.Range(-spawnrange, spawnrange), 1f, UnityEngine.Random.Range(spawnPosz, SpawnPosz2));
        int enemy›ndex = UnityEngine.Random.Range(0, enemyprefabs.Length);
        Instantiate(enemyprefabs[enemy›ndex], spawnpos, enemyprefabs[enemy›ndex].transform.rotation);
    }

    void AirPlaneSpawn()
    {
        Vector3 spawnpos2 = new Vector3(UnityEngine.Random.Range(-spawnrange, spawnrange), 5f, UnityEngine.Random.Range(spawnPosz, SpawnPosz2));
        int AirEnemy›ndex = UnityEngine.Random.Range(0, airplanespawn.Length);
        Instantiate(airplanespawn[AirEnemy›ndex], spawnpos2, airplanespawn[AirEnemy›ndex].transform.rotation);

    }
}
