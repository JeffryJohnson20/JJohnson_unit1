using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Turns the car
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


    }
}
