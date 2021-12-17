using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour

{


    float timeLeft = 0f;
    float startingTime = 10f;
    public Text Countdown;
    public TextMeshProUGUI gameOverText;
    private Spawn spawn;


    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindObjectOfType<Spawn>();
        timeLeft = startingTime;
        spawn.endSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        Countdown.text = timeLeft.ToString("0.0");

        if(timeLeft < 0)
        {
            Debug.Log("Game Over!");
            GameOver();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0); //1. Reference in source 
        }


    }

    public void TimeLimit(int time)
    {
        timeLeft += time;
        Debug.Log(time);

    }




    public void EndGame(int time)
    {
        time += time;
        Debug.Log(time);
      
        
    }


    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        timeLeft = 0;
        spawn.endSpawn = true;
    }



}
