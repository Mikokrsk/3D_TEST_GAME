using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_control : MonoBehaviour
{
    public Transform target;
    public Transform player;

    public float speed=5f;
    //var vec = player.position - enemy.position;
    //if (vec.sqrMagnitude< 100)
    //{
    //    canvas.enabled = true;
    //   // canvas.transform.LookAt(transform.position + cam.forward);
    //    canvas.transform.LookAt(transform.position + cam.forward);
    //}

  //  gameObject.transform.position += gameObject.transform.forward* speed * Time.deltaTime;

// Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        //  target = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        var vec = player.position - gameObject.transform.position;

        if (vec.sqrMagnitude < 100)
        {
            gameObject.transform.LookAt(player); 
        }
        else
        {
            gameObject.transform.LookAt(target);
        }

        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;

    }
}
