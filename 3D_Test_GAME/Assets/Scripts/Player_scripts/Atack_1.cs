using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_1 : MonoBehaviour
{
    public GameObject objects;
    public GameObject poison;
    public float force = 10f;

    private void Start()
    {


    }
    void Update()
    {
        //if (objects.activeSelf == true)
        // Shoot();
    }

    //public void Shoot()
    //{
    //    StartCoroutine(Destroy_poison());




    //}


    //IEnumerator Destroy_poison()
    //{
    //    yield return new WaitForSeconds(2.5f);
        
    //    Instantiate(poison, Vector3.zero, Quaternion.identity);
    //    //    rb.AddForce(transform.forward * force, ForceMode.Impulse);
    //    //  rb.AddForce(transform.up * force / 2, ForceMode.Impulse);
    //    yield return new WaitForSeconds(0.5f);
    //      Destroy(gameObject); 
    //}
}
