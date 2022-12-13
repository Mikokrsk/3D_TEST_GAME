using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_settings : MonoBehaviour
{  
    public int health = 100;
   // private bool alive = true;

    public Rotate_HP rotate_HP;

    void Start()
    {
        rotate_HP = GetComponent<Rotate_HP>();
    }

    //Take damage 
    private void OnTriggerEnter(Collider other)
    {
       Bullet damage = other.GetComponent<Bullet>();

     if(damage != default)
        {
            health -= damage.damage;
       //     text.text = health.ToString();
            minus_hp (damage.damage);
        }

    }

    public void minus_hp(int damage)
    {
       if(health<=0)
        {
            dead();
        }
       else
        {
            rotate_HP.minus_hp(damage);
        }

    }

    public void dead()
    {
        GameObject.Destroy(gameObject);
    }
}
