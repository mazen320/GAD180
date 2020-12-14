using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public int Points = 0;
    public Text Text;

    public Transform player;
    private GameObject lastCollision;

    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision col) 
    {

        if (col.gameObject.tag == "pointobj" && col.gameObject != lastCollision)
        {
            Debug.Log("Player1");
            Debug.Log(Points);
            col.gameObject.SetActive(false);
            Points ++;
            Text.text = Points.ToString ();
            lastCollision = col.gameObject;
        }
    }
    
}
