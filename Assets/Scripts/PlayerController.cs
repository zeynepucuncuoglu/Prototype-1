using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame updatety
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //moves the the car forward based on vertical inp
        transform.Translate(Vector3.forward*Time.deltaTime*speed* horizontalInput);
        //moves the car based on vertical inp
        transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed* verticalInput);
    }
}
