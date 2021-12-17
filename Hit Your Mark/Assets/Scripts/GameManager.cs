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
    private shoot Shoot;
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI RforMenu;


    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindObjectOfType<Spawn>();
        Shoot = GameObject.FindObjectOfType<shoot>();
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
    }




    public void EndGame(int time)
    {
        time += time;
        
      
        
    }


    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        finalScore.gameObject.SetActive(true);
        RforMenu.gameObject.SetActive(true);
        finalScore.SetText("Final Score: " + Shoot.killed);

        timeLeft = 0;
        spawn.endSpawn = true;
    }



}
