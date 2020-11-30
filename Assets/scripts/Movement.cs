using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 30.0f;

    public float torque = 5.0f;
    private Rigidbody rb;

    public string VerticalAxisName;
    public string HorizontalAxisName;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis(HorizontalAxisName);
        float forwards = Input.GetAxis(VerticalAxisName);

        transform.Rotate(0, turn * rotationSpeed,0);
        //rb.AddTorque(transform.up * torque * turn);
        transform.Translate(0, 0, forwards * Time.deltaTime * movementSpeed);
    }
    void FixedUpdate() 
    {
        
    }
}
