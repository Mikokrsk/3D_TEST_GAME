using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move_Controller : MonoBehaviour
{
    public Animator anim;

<<<<<<< HEAD
    public static KeyCode _run_Forward ;
    public static KeyCode _run_Left ;
    public static KeyCode _run_Back ;
    public static KeyCode _run_Right ;

=======
    public static KeyCode _run_Forward = KeyCode.W;
    public static KeyCode _run_Left = KeyCode.A;
    public static KeyCode _run_Back = KeyCode.S;
    public static KeyCode _run_Right = KeyCode.D;
>>>>>>> parent of c72cd9eb (Change setings menu)
    public float speed = 5f;


    void Start()
    {
<<<<<<< HEAD

           Change_button();
        anim = GetComponent<Animator>();
    }

    public static void Change_button()
    {
        _run_Forward = Setings_Menu_Script._run_Forward; ;
        _run_Left= Setings_Menu_Script._run_Left; 
        _run_Back = Setings_Menu_Script._run_Back;
        _run_Right = Setings_Menu_Script._run_Right; 
    }


=======
        anim = GetComponent<Animator>();
    }

    public void Test()
    {
        Debug.Log($"_run_Forward = {_run_Forward} + _run_Left =  {_run_Left} + _run_Back = {_run_Back} + _run_Right {_run_Right}");
    }
    // Update is called once per frame
>>>>>>> parent of c72cd9eb (Change setings menu)
    void Update()
    {
        if (anim.GetBool("isWalk") && anim.GetBool("isLive"))
            Walk();
    } 

    void Walk()
        {
<<<<<<< HEAD
        if (Input.GetKey(_run_Forward) && Input.GetKey(_run_Back) || Input.GetKey(_run_Left) && Input.GetKey(_run_Right))
=======
        if (Input.GetKey(_run_Forward) && Input.GetKey(_run_Back) || Input.GetKey(_run_Forward) && Input.GetKey(_run_Back))
>>>>>>> parent of c72cd9eb (Change setings menu)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            // Forward
            if (Input.GetKey(_run_Forward))
                {
                    gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                if (Input.GetKeyUp(_run_Forward))
                {
                    anim.SetBool("Walk", false);
                }


                //Back
                if (Input.GetKey(_run_Back))
                {
                    gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                 if (Input.GetKeyUp(_run_Back))
                {
                    anim.SetBool("Walk", false);
                }


                //Right
                if (Input.GetKey(_run_Right))
                {
                    gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                 if(Input.GetKeyUp(_run_Right))
                {
                    anim.SetBool("Walk", false);
                }


                //Left
                if (Input.GetKey(_run_Left))
                {
                    gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                if (Input.GetKeyUp(_run_Left))
                {
                    anim.SetBool("Walk", false);
                }
            }
    }
}
