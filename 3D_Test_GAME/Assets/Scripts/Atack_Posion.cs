using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack_Posion : MonoBehaviour
{
    public GameObject objects;
    public GameObject posion;
   // public float force = 500f;
    public Transform spawn_posion;
  //  public bool obj;
   // public int x = 0;
   // public int y = 0;
   // public int z = 0;
    // Update is called once per frame
    private void Start()
    {
        //objects= GetComponent<>();
    }
    void Update()
    {
        if(objects.activeSelf == true)
        Shoot();
    }
    void Shoot()
    {
        Vector3 vector3 = new Vector3(0, 0, 0);
        GameObject gameObject = Instantiate(posion,spawn_posion.position,Quaternion.identity);
      //  gameObject.GetComponent<Rigidbody>().AddForce(vector3.normalized*force, ForceMode.Impulse);
    }
}
