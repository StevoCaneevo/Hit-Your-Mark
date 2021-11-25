using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{

    public float speed = 40.0f;
    public Camera cam1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(cam1.transform.up * Time.deltaTime * speed);
    }
}
