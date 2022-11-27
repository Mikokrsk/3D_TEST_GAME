using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Text text;
    public Transform cam;
    public Transform player;
    public Transform cub;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var vec = player.position - cub.position;
        if(vec.sqrMagnitude < 100)
        {
            text.enabled = true;
       text.text = "11111111111";
        transform.LookAt(transform.position + cam.forward);
        }
        else
        {
            text.enabled = false;
        }
    }
    
  //  SceneManager.LoadScene(0);
}
