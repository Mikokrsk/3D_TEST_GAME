using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_script : MonoBehaviour
{
   // public Transform main_menu;
    public Transform setings_menu;
    public Transform video_menu;
   // public Transform audio_menu;
    public Transform keybord_mouse_menu;

    public GameObject choice_menu;

    // Start is called before the first frame update
    void Start()
    {
        setings_menu.transform.localScale = Vector3.zero;
        video_menu.transform.localScale = Vector3.zero;
      //  audio_menu.transform.localScale = new Vector3(0, 0, 0);
        keybord_mouse_menu.transform.localScale = Vector3.zero;
     //   choice_menu.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (choice_menu.active == false)
            {



                if (keybord_mouse_menu.localScale.x != 0)
                {
                    keybord_mouse_menu.transform.localScale = Vector3.zero;
                }
                else
                {
                    if (video_menu.transform.localScale.x != 0)
                    {
                        video_menu.transform.localScale = Vector3.zero;
                    }
                    else
                    {
                        if (setings_menu.localScale.x != 0)
                        {
                            setings_menu.transform.localScale = Vector3.zero;
                        }
                        else
                        {
                            setings_menu.transform.localScale = Vector3.one; //new Vector3(1, 1, 1);

                        }
                    }
                }
            }
            
        }
    }
/*    public Transform main_menu;
    public Transform setings_menu;
    public Transform video_menu;
    // public Transform audio_menu;
    public Transform keybord_mouse_menu;*/
    
    public void Active_setings_menu(bool active)
    {
        if(active==true)
        {
            setings_menu.transform.localScale = Vector3.one;
        }
        else
        {
            setings_menu.transform.localScale = Vector3.zero;
        }
        
    }

    public void Active_video_menu(bool active)
    {
        if (active == true)
        {
            video_menu.transform.localScale = Vector3.one;
        }
        else
        {
            video_menu.transform.localScale = Vector3.zero;
        }
    }

    public void Active_keybord_mouse_menu(bool active)
    {
        if (active == true)
        {
            keybord_mouse_menu.transform.localScale = Vector3.one;
        }
        else
        {
            keybord_mouse_menu.transform.localScale = Vector3.zero;
        }
    }

 /*   public void Active_choice_menu(bool active)
    {
        if (active == true)
        {
            choice_menu.transform.localScale = Vector3.one;
        }
        else
        {
            choice_menu.transform.localScale = Vector3.zero;
        }
    }*/

}
