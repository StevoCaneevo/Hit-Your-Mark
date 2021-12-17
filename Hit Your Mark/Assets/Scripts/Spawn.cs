using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnPrefabs;

    private float startDelay = 2;
    public float spawnInterval = 2.0f;
    public int cooldown = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

            InvokeRepeating("SpawnRandom", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown + 1;   
    }


    void SpawnRandom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(21, 8),
        0, -300);

        Vector3 powerUpPos = new Vector3(Random.Range(21, 8),
    2, -300);


        int prefabIndex = Random.Range(0, 2);
        Instantiate(spawnPrefabs[prefabIndex], spawnPos,
            spawnPrefabs[prefabIndex].transform.rotation);

        if(cooldown > 2000)
        {
            Instantiate(spawnPrefabs[3], powerUpPos,
            spawnPrefabs[3].transform.rotation);
            cooldown = 0;
        }
    }


}
