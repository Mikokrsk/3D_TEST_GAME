using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_Posion : MonoBehaviour
{
    public GameObject objects;
    public GameObject posion;
   // public GameObject posion_2;
    public float force = 10f;
    public Transform spawn_position;
    public Transform spawn_position_2;
    public GameObject spawn_position_3;
   // public Transform spawn_rotation;
   //  public bool obj;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    public float x1= 0;
    public float y1 = 0;
    public float z1= 0;
    // Update is called once per frame
    private void Start()
    {
        //objects= GetComponent<>();
    }
    void Update()
    {
        if (objects.activeSelf == true)
        Shoot();
    }
    void Shoot()
    {

        Rigidbody rb = Instantiate(posion, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*5f,ForceMode.Impulse);
    }
}
