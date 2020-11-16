using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 30.0f;

    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        float forwards = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, turn *rotationSpeed*Time.deltaTime);
        transform.Translate(0, 0, forwards * Time.deltaTime * movementSpeed);
    }

    void FixedUpdate() 
    {
        
    }
}
