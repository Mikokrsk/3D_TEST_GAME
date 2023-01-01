using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Controller : MonoBehaviour
{
    public float health = 100f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("isLive"))
            Take_Damage();
    }

   public void Take_Damage()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isTake_Damage");
            health -= 30;
            Debug.Log(health);
        }
        if (health <= 0f)
        {
            anim.SetBool("isLive", false);
        }
    }
}
