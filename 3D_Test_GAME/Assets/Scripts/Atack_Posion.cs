using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_Posion : MonoBehaviour
{
    public GameObject objects;
    public GameObject poison;
    public float force = 10f;

    private void Start()
    {


    }
    void Update()
    {
        if (objects.activeSelf == true)
        Shoot();
    }
    void Shoot()
    {

        Rigidbody rb = Instantiate(poison, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*force,ForceMode.Impulse);
        rb.AddForce(transform.up*force/2,ForceMode.Impulse);

    }
}
