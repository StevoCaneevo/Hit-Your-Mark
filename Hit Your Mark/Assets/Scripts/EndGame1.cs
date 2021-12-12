using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame1 : MonoBehaviour

{


    float timeLeft = 0f;
    float startingTime = 60f;
    public Text Countdown;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        Countdown.text = timeLeft.ToString();
    }

    public void TimeLimit(int time)
    {
        timeLeft += time;
        Debug.Log(time);
        Debug.Log("AAAAAAAAAAAAAAAA");

    }




    public void EndGame(int time)
    {
        time += time;
        Debug.Log(time);
        Debug.Log("AAAAAAAAAAAAAAAA");

    }



}
