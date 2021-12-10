using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int kills = 0;
       
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject enemy1;
    // Start is called before the first frame update
    void Start()
    {

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
        }

        if (other.tag == "ArrowFire")
        {
            Debug.Log("HIT2");
            Destroy(gameObject);
            Destroy(other.gameObject);

        }

        if (other.tag == "ArrowIce")
        {
            Debug.Log("HIT3");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }





    
      //    Destroy(gameObject);
      //    Destroy(other.gameObject);

    }
}
