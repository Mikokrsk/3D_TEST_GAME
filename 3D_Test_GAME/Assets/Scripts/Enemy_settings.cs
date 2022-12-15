using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_settings : MonoBehaviour
{
    public int health_max;
    public int health;
   // private bool alive = true;

    public Rotate_HP rotate_HP;
    public Canvas canvas;
    public Slider slider;

    void Start()
    {  
        rotate_HP = GetComponent<Rotate_HP>();
        slider = GetComponentInChildren<Slider>();
    
            health = health_max;
        slider.maxValue = health;
        slider.value = health;
        //rotate_HP.hp_max(health_max);

       // rotate_HP.hp(health);

        //if (health == default || health == 0)
        //{
        //    health = health_max;
        //    rotate_HP.hp(health_max);
        //}
        //else
        //{
        //    rotate_HP.hp(health);
        //}

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
            slider.value = health;
            //rotate_HP.hp(health);
            rotate_HP.minus_hp(damage);
        }

    }

    public void dead()
    {
        GameObject.Destroy(gameObject);
    }
}
