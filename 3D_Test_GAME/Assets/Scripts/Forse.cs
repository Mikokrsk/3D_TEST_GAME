using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forse : MonoBehaviour
{
   // public float thrust = 10.0f;
    public Rigidbody rb;
    public Transform transforms;
    public GameObject gameObject;
    public bool  x =true;
    void Start()
    {

       // StartCoroutine(Scale_poison());
        StartCoroutine(Destroy_poison());
    }

    IEnumerator Destroy_poison()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }


    void OnCollisionEnter(Collision other)
    {
        if(x)
        {
        transforms.transform.localScale += new Vector3(0.7f, -0.12f, 0.7f);
            x = false;
        }
   
    }
  
}