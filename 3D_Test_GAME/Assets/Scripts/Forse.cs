using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forse : MonoBehaviour
{   
    public float thrust = 10.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}
