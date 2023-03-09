using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//using UnityEngine.Windows;

public class Setings_Menu_Script : MonoBehaviour
{
    public GameObject Choice_menu;
    public Text[] _text ;
    private int[] _values ;
    [SerializeField]
    private int[] _keyCodes ;

    public static KeyCode _run_Forward = KeyCode.W;
    public static KeyCode _run_Left = KeyCode.A;
    public static KeyCode _run_Back = KeyCode.S;
    public static KeyCode _run_Right = KeyCode.D;   
    public static KeyCode _attack_1 = KeyCode.Alpha1;
    public static KeyCode _attack_2 = KeyCode.Alpha2; 
    public static KeyCode _attack_3 = KeyCode.Alpha3;

    public const string saveKey = "Setings_Menu_Save";

    private void Save()
    {
        SaveManager.Save(saveKey,GetSaveSnapshot());
    }

    private SaveData.Menu_Save GetSaveSnapshot()
    {
        var data = new SaveData.Menu_Save()
        {
            Run_Forward = (int)_run_Forward,
            Run_Back = (int)_run_Back,
            Run_Left = (int)_run_Left,
            Run_Right = (int)_run_Right,
            Attack_1 = (int)_attack_1,
            Attack_2 = (int)_attack_2,
            Attack_3 = (int)_attack_3,
        };
        return data;
    }

    private void Load()
    {
        var data = SaveManager.Load<SaveData.Menu_Save>(saveKey);
        _run_Forward = (KeyCode)data.Run_Forward; 
        _run_Left= (KeyCode)data.Run_Left;
        _run_Back= (KeyCode)data.Run_Back;
        _run_Right= (KeyCode)data.Run_Right;
        _attack_1= (KeyCode)data.Attack_1;
        _attack_2= (KeyCode)data.Attack_2;
        _attack_3= (KeyCode)data.Attack_3;
        Debug.Log(data.Run_Forward.ToString());
    }

    void Awake()
    {
        _keyCodes = new int[_text.Length];
        _values = (int[])System.Enum.GetValues(typeof(KeyCode));
    }

    private void Start()
    {
       // Choice_menu = GetComponent<GameObject>();
        Load();
        _keyCodes[0] = (int)_run_Forward;
        _keyCodes[1] = (int)_run_Left;
        _keyCodes[2] = (int)_run_Back;
        _keyCodes[3] = (int)_run_Right;
        _keyCodes[4] = (int)_attack_1;
        _keyCodes[5] = (int)_attack_2;
        _keyCodes[6] = (int)_attack_3;

        int x = 0;
        foreach (var item in _keyCodes)
        {

            _text[x].text = ((KeyCode)item).ToString();
            x++;
        }
       
    }
    
    public void FindDuplicates(int num)
    { 
        int x = 0;
        foreach (var item in _keyCodes)
        {
            if (_keyCodes[x] == num)
            {
             _keyCodes[x] = (int)KeyCode.None;
             _text[x].text = KeyCode.None.ToString();
            }       
            x++;
        }

    }

    public void SaveValues()
    {
         _run_Forward =(KeyCode)_keyCodes[0];
         _run_Left = (KeyCode)_keyCodes[1];
        _run_Back = (KeyCode)_keyCodes[2];
        _run_Right = (KeyCode)_keyCodes[3];
        _attack_1 = (KeyCode)_keyCodes[4];
        _attack_2 = (KeyCode)_keyCodes[5];
        _attack_3 = (KeyCode)_keyCodes[6];
        Save();
    }

    public void Default_values()
    {
        _keyCodes[0] = (int)KeyCode.W;
        _keyCodes[1] = (int)KeyCode.A;
        _keyCodes[2] = (int)KeyCode.S;
        _keyCodes[3] = (int)KeyCode.D;
        _keyCodes[4] = (int)KeyCode.Alpha1;
        _keyCodes[5] = (int)KeyCode.Alpha2;
        _keyCodes[6] = (int)KeyCode.Alpha3;

        int x = 0;
        foreach (var item in _keyCodes)
        {
            _text[x].text = ((KeyCode)item).ToString();
            x++;
        }
        SaveValues();
    }

    public void GetKeyCode(int num_button)
    {
        Choice_menu.SetActive(true);
        StartCoroutine(Coroutine(num_button));
    }

    IEnumerator Coroutine(int x)
    {
       
        if (Input.anyKeyDown)
        {
           // Debug.Log("111111111111111111");
            for (int i = 0; i < _values.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    StopCoroutine(Coroutine(x));
                    break;
                }
                else
                {
                    if (Input.GetKey((KeyCode)_values[i]))
                    {
                        FindDuplicates(_values[i]);
                        _text[x].text = ((KeyCode)_values[i]).ToString();
                        _keyCodes[x] = _values[i];
                        SaveValues(); 
                        Save();
                        StopCoroutine(Coroutine(x));
                        break;
                    }
                }
            }
            Choice_menu.SetActive(false);
            StopCoroutine(Coroutine(x));
        }
        else
        {
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(Coroutine(x));
        }
    }
}
