using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{


    public GameObject Projectile1;
    public GameObject Projectile2;
    public GameObject Projectile3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.J))
        {
            // Launch projectile from player
            Instantiate(Projectile1, transform.position, Projectile1.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            // Launch projectile from player
            Instantiate(Projectile2, transform.position, Projectile2.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            // Launch projectile from player
            Instantiate(Projectile3, transform.position, Projectile3.transform.rotation);
        }

    }
}
