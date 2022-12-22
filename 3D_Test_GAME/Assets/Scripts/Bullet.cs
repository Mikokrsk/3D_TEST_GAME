using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // public float thrust = 10.0f;
    //  public Rigidbody rb;
    // public Transform transforms;
    //  public GameObject gameObject;
    //  public bool  x = true;
    //  public float bullet_damage;
    public int damage = 5;
    void Start()
    {
        //damage = 5;
        //Random.Range(1, 100);

        StartCoroutine(Destroy_poison());
    }

    IEnumerator Destroy_poison()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }


    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);

        //if(x)
        //{
        //transforms.transform.localScale += new Vector3(0.7f, -0.12f, 0.7f);
        //    x = false;
        //}

    }

}