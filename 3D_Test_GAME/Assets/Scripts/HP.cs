using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System;

public class HP : MonoBehaviour
{    private  Text health_text;
     private  Text minus_health_text;
    //public Text text;
    public Transform cam;
    public Transform player;
    public Transform enemy;
    //public Text text2;
    public Canvas canvas;
    //  public float x ;
    // public  Random rnd = new Random();
    //public  int num = rnd.Next();
    public List<Text> texts ;
    void Start()
    {
       
        canvas = GetComponentInChildren<Canvas>();
        enemy = GetComponent<Transform>();
        texts.AddRange(canvas.GetComponentsInChildren<Text>());
        texts.ToArray();
        health_text =  texts[0];
        minus_health_text = texts[1];
    }


    void LateUpdate()
    {
        var vec = player.position - enemy.position;
        if (vec.sqrMagnitude < 100)
        {
            canvas.enabled = true;
           canvas.transform.LookAt(transform.position + cam.forward);
        }
        else
        {
            canvas.enabled = false;
        }
    }

    public void hp(int x)
    {
        minus_health_text.enabled = true;
        minus_health_text.text = $" - {x}";
    }

}
