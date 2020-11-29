using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShooting1 : MonoBehaviour
{

    public GameObject Shell;
    public GameObject bulletposition;
    private Rigidbody rb;
    private float recoil = 400.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject clone = Instantiate(Shell);
            clone.transform.position = bulletposition.transform.position;
            clone.GetComponent<Rigidbody>().velocity = bulletposition.transform.forward* -1 * 50;
            rb.AddForce(transform.forward * recoil);
            Destroy(clone, 5f);
        }
    }
}
