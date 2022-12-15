using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System;

public class Rotate_HP : MonoBehaviour
{   
    
    private  Text health_text;
    private  Text minus_health_text;

    private Transform cam;
    private Transform player;

    private Transform enemy;

    private Canvas canvas;

    public Slider slider;
    //  public float x ;
    // public  Random rnd = new Random();
    //public  int num = rnd.Next();
    public List<Text> texts ;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        cam = Camera.main.GetComponent<Transform>();
        canvas = GetComponentInChildren<Canvas>();
        enemy = GetComponent<Transform>();
        texts.AddRange(canvas.GetComponentsInChildren<Text>());

        texts.ToArray();

        health_text =  texts[0];
        minus_health_text = texts[1];


        //Slider (Health bar)
        //slider = canvas.GetComponentInChildren<Slider>();

        //slider.maxValue = 666;
    }


    void LateUpdate()
    {
        var vec = player.position - enemy.position;
        if (vec.sqrMagnitude < 100)
        {
            canvas.enabled = true;
           // canvas.transform.LookAt(transform.position + cam.forward);
            canvas.transform.LookAt(transform.position + cam.forward);
        }
        else
        {
            canvas.enabled = false;
        }
    }

    public void minus_hp(int x)
    {
      //  minus_health_text.enabled = true;
        minus_health_text.text = $" - {x}";
    }

    //public void hp_max(float health_max)
    //{
    //    try
    //    {
    //        slider.maxValue = health_max;
    //    }
    //    catch
    //    {
    //        Debug.Log($"HP_MAX = {health_max}");
    //    }
    //}

    //public void hp(float health)
    //{
    //    try
    //    {


    //        slider.value = health;
    //    }
    //    catch
    //    {
    //        Debug.Log($"HP = {health}");
    //    }
        

        
    //}

}
