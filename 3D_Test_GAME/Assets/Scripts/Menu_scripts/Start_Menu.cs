using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Start_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public string run_Forward = "w";
    public string run_Back = "s";
    public string run_Right = "d";
    public string run_Left = "a";
    public string fire_1 = "1";
    public string fire_2 = "2";
    public string fire_3 = "3";

    public Text run_Forward_txt;
    public Text run_Back_txt;
    public Text run_Right_txt;
    public Text run_Left_txt;
    public Text fire_1_txt;
    public Text fire_2_txt;
    public Text fire_3_txt; 

    public InputField forward_input;
    public InputField back_input;
    public InputField right_input;
    public InputField left_input;
    public InputField fire_1_input;
    public InputField fire_2_input;
    public InputField fire_3_input;


    void Start()
    {
        run_Forward_txt.text = run_Forward  = PlayerPrefs.GetString("run_Forward");
        run_Back_txt.text = run_Back = PlayerPrefs.GetString("run_Back");
        run_Right_txt.text = run_Right = PlayerPrefs.GetString("run_Right");
        run_Left_txt.text = run_Left = PlayerPrefs.GetString("run_Left");
        fire_1_txt.text = fire_1 = PlayerPrefs.GetString("fire_1");
        fire_2_txt.text = fire_2 = PlayerPrefs.GetString("fire_2");
        fire_3_txt.text = fire_3 = PlayerPrefs.GetString("fire_3");
    }


    // Update is called once per frame
    void Update()
    {
        

        //run_Forward_txt.text = run_Forward;
        //run_Back_txt.text = run_Back;
        //run_Right_txt.text = run_Right;
        //run_Left_txt.text = run_Left;
        //fire_1_txt.text = fire_1;
        //fire_2_txt.text = fire_2;
        //fire_3_txt.text = fire_3;
    }

    public void Button_Start()
    {
        
        SceneManager.LoadScene(1);
    }
    //run_Forward = forward_input.text;
        //run_Back = back_input.text;
        //run_Right = right_input.text;
        //run_Left = left_input.text;
        //fire_1 = fire_1_input.text;
        //fire_2 = fire_2_input.text;
        //fire_3 = fire_3_input.text;
    public void Save_Setings()
    {
        if(forward_input.text.Length == 1 && forward_input.text!=" ")
        {
            PlayerPrefs.SetString("run_Forward", forward_input.text);
            run_Forward_txt.text = forward_input.text;
        }

        if (back_input.text.Length == 1 && back_input.text != " ")
        {
            PlayerPrefs.SetString("run_Back", back_input.text);
            run_Back_txt.text = back_input.text;
        }

        if (right_input.text.Length == 1 && right_input.text != " ")
        {
            PlayerPrefs.SetString("run_Right", right_input.text);
            run_Right_txt.text = right_input.text;
        }

        if (left_input.text.Length == 1 && left_input.text != " ")
        {
            PlayerPrefs.SetString("run_Left", left_input.text);
            run_Left_txt.text = left_input.text;
        }

        if (fire_1_input.text.Length == 1 && fire_1_input.text != " ")
        {
            PlayerPrefs.SetString("fire_1", fire_1_input.text);
            fire_1_txt.text = fire_1_input.text;
        }

        if (fire_2_input.text.Length == 1 && fire_2_input.text != " ")
        {
            PlayerPrefs.SetString("fire_2", fire_2_input.text);
            fire_2_txt.text = fire_2_input.text;
        }

        if (fire_3_input.text.Length == 1 && fire_3_input.text != " ")
        {
        PlayerPrefs.SetString("fire_3", fire_3_input.text);
            fire_3_txt.text = fire_3_input.text;
        }
    
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
