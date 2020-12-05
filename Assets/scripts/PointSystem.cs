using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int Player1points = 0;
    public int Player2points = 0;
    private string Points;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col) 
    {
        if (gameObject.tag == "Player1")
        {
        if (col.gameObject.tag == "pointobj")
        {
            Debug.Log("Player1");
            Debug.Log(Player1points);
            col.gameObject.SetActive(false);
            Player1points ++;
        }
    }

        if (gameObject.tag == "Player2")
        {
        if (col.gameObject.tag == "pointobj")
        {
            Debug.Log("Player2");
            Debug.Log(Player2points);
            col.gameObject.SetActive(false);
            Player2points ++;
        }
    }
    }
}
