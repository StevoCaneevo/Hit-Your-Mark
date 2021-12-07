using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 30.0f;

    public float xRange = 10;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < 5)
        {
            transform.position = new Vector3(5, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 23)
        {
            transform.position = new Vector3(23, transform.position.y, transform.position.z);
        }

      
    }
}
