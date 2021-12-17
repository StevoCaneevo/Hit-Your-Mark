using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRun : MonoBehaviour
{

    public float speedIncrease = 10f;
    public float spawnInterval = 2.0f;
    public Spawn spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindObjectOfType<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * spawn.speed);
    }








}
