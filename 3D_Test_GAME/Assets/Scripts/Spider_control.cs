using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spider_control : MonoBehaviour
{

    public Animator anim;
    public float health = 100f;
    
    public string run_Forward = "w";
    public string run_Back = "s";
    public string run_Right = "d";
    public string run_Left = "a";
    public string fire_1 = "1";
    public string fire_2 = "2";
    public string fire_3 = "3";
    //float position_spider_x = 0;
    //float position_spider_y = 0;
    //float position_spider_z = 0;
   // public Atack_3 atack_3;
    public Transform position_3;

    public GameObject bullet_3;
    public float force = 10f;
  //  public float x;

    public bool cooldawn_fire_1=true;
    public bool cooldawn_fire_2=true;
    public bool cooldawn_fire_3=true;

    public Transform position_1;
    public GameObject bullet_1;

    public Transform position_2;
    public GameObject bullet_2;

    public int speed = 5;

    void Start()
    {
       // atack_3 = GetComponentInChildren<Atack_3>();
        anim = GetComponent<Animator>();
        run_Forward = PlayerPrefs.GetString("run_Forward");
        run_Back = PlayerPrefs.GetString("run_Back");
        run_Right = PlayerPrefs.GetString("run_Right");
        run_Left = PlayerPrefs.GetString("run_Left");
        fire_1 = PlayerPrefs.GetString("fire_1");
        fire_2 = PlayerPrefs.GetString("fire_2");
        fire_3 = PlayerPrefs.GetString("fire_3");
        //position_spider_x = PlayerPrefs.GetFloat("Transform_spider_X");
        //position_spider_y = PlayerPrefs.GetFloat("Transform_spider_Y");
        //position_spider_z = PlayerPrefs.GetFloat("Transform_spider_Z");
        //gameObject.transform.position = new Vector3(position_spider_x,position_spider_y,position_spider_z);
    }


    void Update()
    {   if(Input.GetKeyDown(KeyCode.Escape))
        {

            //PlayerPrefs.SetFloat( "Transform_spider_X", gameObject.transform.position.x);
            //PlayerPrefs.SetFloat( "Transform_spider_Y", gameObject.transform.position.y);
            //PlayerPrefs.SetFloat( "Transform_spider_Z", gameObject.transform.position.z);
            SceneManager.LoadScene(0);
        }

        if (anim.GetBool("is_Live"))
        {  
            Fire_3();
            Fire_2();
            Fire_1();          
            Take_Damage();
            if(anim.GetBool("Move"))
            Walk();
        }
        else
        {
            anim.SetTrigger("Take_Damage");
            anim.SetBool("is_Live", false);
        }      
    }


    void Fire_3()
    {
        if(Input.GetKeyDown(fire_3) && cooldawn_fire_3 == true)
        {
            Move();
            //  Debug.Log("Fire33333");
            anim.SetTrigger("Fire3");
            Shoot_3();
            
        }
    }

    void Fire_2()
    {
        if(Input.GetKeyDown(fire_2) && cooldawn_fire_2 == true )
        {
            Move();
            // Debug.Log("Fire222222");
            anim.SetTrigger("Fire2");
            Shoot_2();
        }
    }

    void Fire_1()
    {
        if(Input.GetKeyDown(fire_1) & cooldawn_fire_1 == true)
        {
            Move();
           // Debug.Log("Fire111111111");
            anim.SetTrigger("Fire1");
            Shoot_1();
        }
    }

    void Walk()
    { 
        if (Input.GetKey(run_Forward) && Input.GetKey(run_Back) || Input.GetKey(run_Right) && Input.GetKey(run_Left))
        {
            anim.SetBool("Walk", false);
            anim.SetBool("WalkBack", false);
        }
        else
        {
            // Forward
            if (Input.GetKey(run_Forward))
            {
                gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
                anim.SetBool("Walk", true);
            }
            if (Input.GetKeyUp(run_Forward))
            {
                anim.SetBool("Walk", false);
            }


            //Back
            if (Input.GetKey(run_Back))
            {
                gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
                anim.SetBool("WalkBack", true);
            }
            if (Input.GetKeyUp(run_Back))
            {
                anim.SetBool("WalkBack", false);
            }


            //Right
            if (Input.GetKey(run_Right))
            {
                gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
                anim.SetBool("WalkBack", true);
            }
            if (Input.GetKeyUp(run_Right))
            {
                anim.SetBool("WalkBack", false);
            }


            //Left
            if (Input.GetKey(run_Left))
            {
                gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
                anim.SetBool("WalkBack", true);
            }
            if (Input.GetKeyUp(run_Left))
            {
                anim.SetBool("WalkBack", false);
            }
        }
    }

    void Take_Damage()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Take_Damage");
            health -= 30;
            Debug.Log(health);
        }
        if(health <= 0f)
        {
            anim.SetBool("is_Live",false);
        }         
    }


    ///////////////////////

    void Move()
    {
        anim.SetBool("Walk", false);
        anim.SetBool("WalkBack", false);
        anim.SetBool("Move",false);
    }
    void No_Move()
    {
        anim.SetBool("Move", true);
    }
    ///////////////////////

    public void Shoot_3()
    {
        StartCoroutine(Destroy_poison_3());

    }


    IEnumerator Destroy_poison_3()
    {
        cooldawn_fire_3 = false;
        yield return new WaitForSeconds(0.2f);
        //  Destroy(gameObject); 
        Rigidbody rb = Instantiate(bullet_3, position_3.position, Quaternion.identity).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
        rb.AddForce(transform.up * force / 2, ForceMode.Impulse);
        yield return new WaitForSeconds(2f);
        No_Move();
        cooldawn_fire_3 = true;
    }


    ////////////////////////

    public void Shoot_2()
    {
        StartCoroutine(Destroy_poison_2());
    }


    IEnumerator Destroy_poison_2()
    {
        cooldawn_fire_2 = false;
        yield return new WaitForSeconds(0.9f);

        Instantiate(bullet_2, position_2.position,Quaternion.identity);
        //    rb.AddForce(transform.forward * force, ForceMode.Impulse);
        //  rb.AddForce(transform.up * force / 2, ForceMode.Impulse);
        yield return new WaitForSeconds(0.3f) ;
        Instantiate(bullet_2, position_2.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        Instantiate(bullet_2, position_2.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        Instantiate(bullet_2, position_2.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
        No_Move();
        cooldawn_fire_2 = true;
        // Destroy(bullet_1);
    }



    ////////////////////////

    public void Shoot_1()
    {
        StartCoroutine(Destroy_poison_1());
    }


    IEnumerator Destroy_poison_1()
    {
        cooldawn_fire_1 = false;
        yield return new WaitForSeconds(1f);

        Instantiate(bullet_1, position_1.position, Quaternion.identity);
        //    rb.AddForce(transform.forward * force, ForceMode.Impulse);
        //  rb.AddForce(transform.up * force / 2, ForceMode.Impulse);
        yield return new WaitForSeconds(2f);
        cooldawn_fire_1 = true;
        // Destroy(bullet_1);
        No_Move();
    }
}
