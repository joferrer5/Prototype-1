    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private float speed = 20.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float fowardInput;
    void Update()
    {
        // Move the vehicle foward

        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");
        // Moves the car foward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        // Moves the car based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
