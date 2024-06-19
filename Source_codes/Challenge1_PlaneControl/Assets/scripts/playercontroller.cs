using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float turnSpeed = 5.0f; 
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // Move vehicle forward 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime );
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}