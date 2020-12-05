using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int points = 0;
    private string Points;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "pointobj")
        {
            Debug.Log(points);
            col.gameObject.SetActive(false);
            points ++;
        }
    }
}
