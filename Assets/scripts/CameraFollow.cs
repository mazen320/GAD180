using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
     
    void Update()
         {                
             transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
         }
}

