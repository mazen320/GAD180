﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShooting : MonoBehaviour
{

    public GameObject Shell;
    public GameObject bulletposition;
    private Rigidbody rb;
    private float recoil = 400.0f;
    public KeyCode ShootingKey;
    private float nextTimeToFire = 0;
    [SerializeField]
    private float fireRate = 5;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ShootingKey) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate;
            GameObject clone = Instantiate(Shell);
            clone.transform.position = bulletposition.transform.position;
            clone.GetComponent<Rigidbody>().velocity = bulletposition.transform.forward * -1 * 50;
            rb.AddForce(transform.forward * recoil);
            Destroy(clone, 5f);
        }
    }
}

