using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] spawnPrefabs;

    private float startDelay = 2;
    public float spawnInterval = 2.0f;
    public int cooldown = 0;
    public bool endSpawn;
    public float speed;
    private float speedIncrease = 3;



    // Start is called before the first frame update
    void Start()
    {

            InvokeRepeating("SpawnRandom", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown + 1;
        speed += speedIncrease * Time.deltaTime;

        if (endSpawn == true)
        {
            CancelInvoke("SpawnRandom");

        }




    }


    void SpawnRandom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(21, 8),
        0, -300);

        Vector3 powerUpPos = new Vector3(Random.Range(21, 8),
    2, -300);


        int prefabIndex = Random.Range(0, 3);
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
