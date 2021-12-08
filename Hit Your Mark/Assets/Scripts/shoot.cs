using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{


    public GameObject Projectile1;
    public GameObject Projectile2;
    public GameObject Projectile3;
    public AudioClip arrow;
    public AudioClip arrowFire;
    public AudioClip arrowIce;
    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.J))
        {
            // Launch projectile from player
            Instantiate(Projectile1, transform.position, Projectile1.transform.rotation);
            playerAudio.PlayOneShot(arrow, 0.2f);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            // Launch projectile from player
            Instantiate(Projectile2, transform.position, Projectile2.transform.rotation);
            playerAudio.PlayOneShot(arrowFire, 0.2f);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            // Launch projectile from player
            Instantiate(Projectile3, transform.position, Projectile3.transform.rotation);
            playerAudio.PlayOneShot(arrowIce, 0.2f);
        }

    }
}
