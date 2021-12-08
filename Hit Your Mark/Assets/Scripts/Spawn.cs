using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    private float spawnRangeX = 14;
    private float spawnPosZ = 21;
    private float startDelay = 2;
    public float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnRandom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(21, 8),
        0, -300);



        int prefabIndex = Random.Range(0, spawnPrefabs.Length);
        Instantiate(spawnPrefabs[prefabIndex], spawnPos,
            spawnPrefabs[prefabIndex].transform.rotation);


    }


}
