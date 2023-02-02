using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Controller : MonoBehaviour
{
    public GameObject Menu;
    public static float max_health = 100f;
    public static float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        //    anim.SetTrigger("isTake_Damage");
            health -= 30;
            max_health += 50;
            Debug.Log(health);
        }
        if (health <= 0f)
        {
          //  anim.SetBool("isLive", false);
        }
    }
}
