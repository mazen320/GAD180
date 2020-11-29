using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 5.0F;
    private Vector3 velocity = Vector3.zero;
     
    void Update()
         {                
            Vector3 targetPosition = target.TransformPoint(new Vector3(0, 3, -7));
            transform.LookAt (target);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
         }
}

