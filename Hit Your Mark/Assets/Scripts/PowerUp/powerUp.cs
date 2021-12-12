using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{

    private shoot Shoot;
    private int kill = 1;
    private EndGame1 EndGame;
    private int time = 35;

    // Start is called before the first frame update
    void Start()
    {
        Shoot = GameObject.FindObjectOfType<shoot>();
        EndGame = GameObject.FindObjectOfType<EndGame1>();
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
            EndGame.TimeLimit(time);
        }
    }
