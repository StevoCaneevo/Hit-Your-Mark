using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public GameObject projectilePrefab;
    public float shootforce = 50f;

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
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch projectile from player
            //Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            var instanceArrow = Instantiate(projectilePrefab, transform.position, transform.rotation);
            instanceArrow.GetComponent<Rigidbody>().AddForce(transform.forward * shootforce);
        }
    }
}
