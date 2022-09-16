using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forse : MonoBehaviour
{
    public float thrust = 10.0f;
    public Rigidbody rb;
    public Transform spawn_position_2;

    void Start()
    {
        //  rb = GetComponent<Rigidbody>();

        //Vector3 vector3 = new Vector3(spawn_position_2.position.x, spawn_position_2.position.y, spawn_position_2.position.z);

        //  rb.AddForce(0,0, thrust, ForceMode.Impulse);
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}