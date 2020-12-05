using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSpawner : MonoBehaviour
{
    public GameObject pointObject;
    private bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    private Vector3 newPos;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
    }

    public void spawnObject()
    {
        Vector3 newPos = new Vector3 (Random.Range(-12,12), Random.Range(3,25), Random.Range(65,350));
        Instantiate(pointObject, newPos, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("spawnObject");
        }
    }
}
