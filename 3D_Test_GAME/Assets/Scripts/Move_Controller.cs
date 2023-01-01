using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Controller : MonoBehaviour
{
    public Animator anim;
    public string run_Forward = "w";
    public string run_Back = "s";
    public string run_Right = "d";
    public string run_Left = "a";
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        run_Forward = PlayerPrefs.GetString("run_Forward");
        run_Back = PlayerPrefs.GetString("run_Back");
        run_Right = PlayerPrefs.GetString("run_Right");
        run_Left = PlayerPrefs.GetString("run_Left");
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("isWalk") && anim.GetBool("isLive"))
            Walk();
    } 

    void Walk()
        {
        if (Input.GetKey(run_Forward) && Input.GetKey(run_Back) || Input.GetKey(run_Right) && Input.GetKey(run_Left))
        {
            anim.SetBool("Walk", false);
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
                    anim.SetBool("Walk", true);
                }
                 if (Input.GetKeyUp(run_Back))
                {
                    anim.SetBool("Walk", false);
                }


                //Right
                if (Input.GetKey(run_Right))
                {
                    gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                 if(Input.GetKeyUp(run_Right))
                {
                    anim.SetBool("Walk", false);
                }


                //Left
                if (Input.GetKey(run_Left))
                {
                    gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
                    anim.SetBool("Walk", true);
                }
                if (Input.GetKeyUp(run_Left))
                {
                    anim.SetBool("Walk", false);
                }
            }
    }
}
