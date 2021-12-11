using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    private shoot Shoot;
    private int kill = 1;
    private enemyRun EnemyRun;
    private float time = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Shoot = GameObject.FindObjectOfType<shoot>();
        EnemyRun = GameObject.FindObjectOfType<enemyRun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

            Debug.Log("Slowmotion!");
            Destroy(gameObject);
            Destroy(other.gameObject);
            Shoot.Score(kill);
            EnemyRun.Slowmotion(time);
        }



    }
