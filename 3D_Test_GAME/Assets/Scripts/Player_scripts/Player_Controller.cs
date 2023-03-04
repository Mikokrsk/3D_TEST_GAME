using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public GameObject Menu;
  //  public static float max_health = 100f;
 //   public static float health = 100f;
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        //Pause game and active setings Menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Menu.active==false)
            {
            Menu.SetActive(true);
            Time.timeScale = 0f;
            }
            else
            {
                Menu.SetActive(false);
                Time.timeScale = 1f;
            }
        }
        Take_Damage();


    }

    public void Take_Damage()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isTake_Damage");
           Player.health -= 30;
            Player.health_max += 50;
            Debug.Log(Player.health);
        }
        if (Player.health <= 0f)
        {
            anim.SetBool("isLive", false);
        }
    }
}
