using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
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
            Debug.Log("HIT1");
            Destroy(gameObject);
            Destroy(other.gameObject);
            Shoot.Score(kill);
        }

        if (other.tag == "ArrowFire")
        {
            Debug.Log("MISS 2");
           // Destroy(other.gameObject);

        }

        if (other.tag == "ArrowIce")
        {
            Debug.Log("MISS 3");
            //Destroy(other.gameObject);
        }





    
      //    Destroy(gameObject);
      //    Destroy(other.gameObject);

    }
}
