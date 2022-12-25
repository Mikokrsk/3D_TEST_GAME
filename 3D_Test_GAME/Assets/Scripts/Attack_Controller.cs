using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attack_Controller : MonoBehaviour
{

    public Animator anim;

    public string attack_1 = "1";
    public string attack_2 = "2";
    public string attack_3 = "3";

    public Transform position_1;
    public GameObject bullet_1;

    public Transform position_2;
    public GameObject bullet_2;

    public Transform position_3;
    public GameObject bullet_3;


    void Start()
    {
        anim = GetComponent<Animator>();
        attack_1 = PlayerPrefs.GetString("fire_1");
        attack_2 = PlayerPrefs.GetString("fire_2");
        attack_3 = PlayerPrefs.GetString("fire_3");
    }


    void Update()
    {  
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (anim.GetBool("isLive"))
        {  
            if(anim.GetBool("isAttack1")== anim.GetBool("isAttack2")== anim.GetBool("isAttack3")==false)
            {
            Attack_3();
            Attack_2();
            Attack_1(); 
            }
        }
     
    }


    void Attack_3()
    {
        if(Input.GetKeyDown(attack_3))
        {
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack3",true);
        }
    }

    void Attack_2()
    {
        if(Input.GetKeyDown(attack_2) )
        {
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack2", true);
        }
    }

    void Attack_1()
    {
        if(Input.GetKeyDown(attack_1))
        {
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack1", true);
        }
    }

}
