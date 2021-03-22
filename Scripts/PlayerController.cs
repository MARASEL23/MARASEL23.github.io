using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player inputs
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");

       // we move the vehicle
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //turn the vehicle
       transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
