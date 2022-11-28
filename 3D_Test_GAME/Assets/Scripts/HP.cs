using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using System;

public class HP : MonoBehaviour
{
    public Text text;
    public Transform cam;
    public Transform player;
    public Transform cub;
    public Text text2;
   // public  Random rnd = new Random();
    //public  int num = rnd.Next();
    public float x ;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var vec = player.position - cub.position;
        if(vec.sqrMagnitude < 100)
        {
           
            x = Random.Range(1f,100f);
          
            text.enabled = true;
    //   text.text = "11111111111";
        transform.LookAt(transform.position + cam.forward);
        }
        else
        {
            text.enabled = false;
        }
    }

    public void hp(float x)
    {
        text2.enabled = true; 
        text2.text = $" - {x}";
    }
    
  //  SceneManager.LoadScene(0);
}
