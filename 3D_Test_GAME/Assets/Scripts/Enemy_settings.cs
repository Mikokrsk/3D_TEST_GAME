using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_settings : MonoBehaviour
{  
    public Text text ;
    public Text text2 ;

    //public float health = 100 ;
    public int health = 100;
    void Start()
    {
        // делаю данный объект триггером
        //  gameObject.GetComponent<BoxCollider>().isTrigger = true;
     //   text.text = health.ToString();
    }







    private void OnTriggerEnter(Collider other)
    {
       Bullet damage = other.GetComponent<Bullet>();

     if(damage != default)
        {
            health -= damage.damage;
       //     text.text = health.ToString();
            hp (damage.damage);
        }

    }

    public void hp (float damage)
    {
        text2.enabled = true;
        text2.text = $" - {damage}";

        //gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
      //  text2.transform.position += new Vector3(0,10,0) ;

    }

}
