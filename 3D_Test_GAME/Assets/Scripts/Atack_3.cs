using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_3 : MonoBehaviour
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

   public void Shoot()
    {
    StartCoroutine(Destroy_poison());
    }


    IEnumerator Destroy_poison()
    {
        yield return new WaitForSeconds(2f);
      //  Destroy(gameObject); 
        Rigidbody rb = Instantiate(poison, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward*force,ForceMode.Impulse);
        rb.AddForce(transform.up*force/2,ForceMode.Impulse);
    }
}
