﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 30.0f;

    public float torque = 5.0f;
    private Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        float forwards = Input.GetAxis("Vertical");

        transform.Rotate(0, turn * rotationSpeed,0);
        //rb.AddTorque(transform.up * torque * turn);
        transform.Translate(0, 0, forwards * Time.deltaTime * movementSpeed);
    }
    void FixedUpdate() 
    {
        
    }
}
