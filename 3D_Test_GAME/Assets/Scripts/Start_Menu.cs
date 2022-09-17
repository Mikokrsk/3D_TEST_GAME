using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_Start()
    {
        SceneManager.LoadScene(1);
    }

    public void Setting()
    {
        //  setting.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
