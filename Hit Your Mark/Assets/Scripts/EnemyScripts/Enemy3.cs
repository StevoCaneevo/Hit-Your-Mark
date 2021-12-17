using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{


    private shoot Shoot;
    private int kill = 1;

    // Start is called before the first frame update
    void Start()
    {
        Shoot = GameObject.FindObjectOfType<shoot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {

        }

        if (other.tag == "ArrowFire")
        {

        }

        if (other.tag == "ArrowIce")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Shoot.Score(kill);
        }






        //    Destroy(gameObject);
        //    Destroy(other.gameObject);

    }
}
