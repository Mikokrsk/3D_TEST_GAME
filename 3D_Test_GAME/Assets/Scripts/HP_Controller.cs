using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HP_Controller : MonoBehaviour
{
  //  public static float max_health = 100f;
   // public static float health ;
    public Slider health_bar;
    public Animator anim;
    // // Start is called before the first frame update
    void Start()
    {
      //  health = Player_Controller.health; 
        health_bar = GetComponent<Slider>();
        // anim = GetComponent<Animator>();
        health_bar.maxValue = Player_Controller.max_health;
        health_bar.value = Player_Controller.health;
    }

    // // Update is called once per frame
    void Update()
    {
        health_bar.maxValue = Player_Controller.max_health;
        health_bar.value = Player_Controller.health;
      //  if (anim.GetBool("isLive"))
         //   Take_Damage();
    }

    //public void Take_Damage()
    //{

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        anim.SetTrigger("isTake_Damage");
    //        health -= 30;
    //        Debug.Log(health);
    //    }
    //    if (health <= 0f)
    //    {
    //        anim.SetBool("isLive", false);
    //    }
    //}
}
