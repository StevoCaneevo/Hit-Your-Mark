using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    private shoot Shoot;
    private int kill = 1;
    private GameManager EndGame;
    private int time = 35;

    // Start is called before the first frame update
    void Start()
    {
        Shoot = GameObject.FindObjectOfType<shoot>();
        EndGame = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Shoot.Score(kill);
            EndGame.TimeLimit(time);
        }
    }
