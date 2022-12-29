using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//using UnityEngine.Windows;

public class Setings_Menu_Script : MonoBehaviour
{

    public Text[] texts ;
    private int[] values;
    private KeyCode[] keyCodes ;
    public static KeyCode run_Forward = KeyCode.W;
    public static KeyCode run_Left = KeyCode.A;
    public static KeyCode run_Back = KeyCode.S;
    public static KeyCode run_Right = KeyCode.D;   
    public static KeyCode attack_1 = KeyCode.Alpha1;
    public static KeyCode attack_2 = KeyCode.Alpha2;
    public static KeyCode attack_3 = KeyCode.Alpha3;


    void Awake()
    {
        keyCodes = new KeyCode[texts.Length];
        values = (int[])System.Enum.GetValues(typeof(KeyCode));
    }

    private void Start()
    {
        keyCodes[0] = run_Forward;
        keyCodes[1] = run_Left;
        keyCodes[2] = run_Back;
        keyCodes[3] = run_Right;
        keyCodes[4] = attack_1;
        keyCodes[5] = attack_2;
        keyCodes[6] = attack_3;

        int x = 0;
        foreach (var item in keyCodes)
        {

            texts[x].text = item.ToString();
            x++;
        }

    }
  //  PlayerPrefs.GetString("run_Forward");


    public void ChangeValues(int num)
    { 
        int x = 0;
        foreach (var item in keyCodes)
        {
            if (keyCodes[x] == (KeyCode)num)
            {
             keyCodes[x] = KeyCode.None;
             texts[x].text = KeyCode.None.ToString();
            }       
            x++;
        }

    }

    public void SaveValues()
    {
         run_Forward = keyCodes[0];
         run_Left = keyCodes[1];
        run_Back = keyCodes[2];
        run_Right = keyCodes[3];
        attack_1 = keyCodes[4];
        attack_2 = keyCodes[5];
        attack_3 = keyCodes[6];
    }

    public void Default_values()
    {
        keyCodes[0] = KeyCode.W;
        keyCodes[1] = KeyCode.A;
        keyCodes[2] = KeyCode.S;
        keyCodes[3] = KeyCode.D;
        keyCodes[4] = KeyCode.Alpha1;
        keyCodes[5] = KeyCode.Alpha2;
        keyCodes[6] = KeyCode.Alpha3;

        int x = 0;
        foreach (var item in keyCodes)
        {
            texts[x].text = item.ToString();
            x++;
        }
        SaveValues();
    }


    public void GetKeyCode(int num_button)
    {
        StartCoroutine(Coroutine(num_button));
    }

    IEnumerator Coroutine(int x)
    {
       
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    StopCoroutine(Coroutine(x));
                    break;
                }
                else
                {
                    if (Input.GetKey((KeyCode)values[i]))
                    {
                        ChangeValues(values[i]);
                        texts[x].text = ((KeyCode)values[i]).ToString();
                        keyCodes[x] = (KeyCode)values[i];
                        StopCoroutine(Coroutine(x));
                        break;
                    }
                }
            }
            StopCoroutine(Coroutine(x));
        }
        else
        {
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(Coroutine(x));
        }
    }
}
