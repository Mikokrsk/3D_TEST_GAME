using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spider_control : MonoBehaviour
{

    public Animator anim;
    public float live = 100f;
    public float x = 0;
    public string x1 = "1";
    public string x2 = "2";
    public string x3 = "3";
    public string x4 = "w";
    public string x5 = "s";
    public string x6 = "d";
    public string x7 = "a";
    public int speed = 5;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }


    void Update()
    {  
        if(Input.GetKey(x4))
        {
            gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
            anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(x4))
        {
            anim.SetBool("Walk", false);
        }

        if(Input.GetKey(x5))
        {
            gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
            anim.SetBool("WalkBack", true);
        }
        if (Input.GetKeyUp(x5))
        {
            anim.SetBool("WalkBack", false);
        }

        if(Input.GetKey(x6))
        {
            gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
            anim.SetBool("WalkBack", true);
        }
        if (Input.GetKeyUp(x6))
        {
            anim.SetBool("WalkBack", false);
        }      
        
        if(Input.GetKey(x7))
        {
            gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
            anim.SetBool("WalkBack", true);
        }
        if (Input.GetKeyUp(x7))
        {
            anim.SetBool("WalkBack", false);
        }



        if (anim.GetBool("is_Live"))
        {

        //    if (Input.GetKeyDown(x4))
        //{
        //    gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
        //    anim.SetBool("Walk", true);
        //}      
       
            Fire_3();
            Fire_2();
            Fire_1();
          //  Walk();
            Take_Damage();
        }
        else
        {
            anim.SetTrigger("Take_Damage");
            anim.SetBool("is_Live", false);
        }

        
    }

    void Fire_3()
    {
        if(Input.GetKeyDown(x1))
        {
          //  Debug.Log("Fire33333");
            anim.SetTrigger("Fire3");
        }
    }
    void Fire_2()
    {
        if(Input.GetKeyDown(x2))
        {
           // Debug.Log("Fire222222");
            anim.SetTrigger("Fire2");
        }
    }
    void Fire_1()
    {
        if(Input.GetKeyDown(x3))
        {
           // Debug.Log("Fire111111111");
            anim.SetTrigger("Fire1");
        }
    }
    void Walk()
    {
        if(Input.GetKeyDown(x4))
        {
            gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
            anim.SetBool("Walk",true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }


    void Take_Damage()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Take_Damage");
            live -= 30;
            Debug.Log(live);
        }
        if(live <= 0f)
        {
            anim.SetBool("is_Live",false);
        }         
    }
    //IEnumerator Destroy_Spider()
    //{
    //    yield return new WaitForSeconds(5f);
    //    Destroy(gameObject);
    //}
    
    //IEnumerator Take_Damade()
    //{
    //    yield return new WaitForSeconds(5f);
    //    anim.SetTrigger("Take_Damage");
    //    live -= 30;
    //    Debug.Log(live);
    //}
}
