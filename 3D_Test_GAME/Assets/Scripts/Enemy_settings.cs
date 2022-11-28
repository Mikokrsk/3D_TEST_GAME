using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_settings : MonoBehaviour
{  
    public Text text ;
    public Text text2 ;

    public float health = 100 ;

    void Start()
    {
        // ����� ������ ������ ���������
        //  gameObject.GetComponent<BoxCollider>().isTrigger = true;
        text.text = health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        // other - ������, � ������� ��������� ������������
        // ������� �������� ��������� (������) �������
       Forse bullet = other.GetComponent<Forse>();
     //   Console.WriteLine($" - {bullet.damage}");
     if( bullet != default)
        {
            health -= bullet.damage;
            text.text =health.ToString();
            hp (bullet.damage);
        }

        // ���� � ������� ������� ���� ��������� "yyy"
    //    if (s != null)
  //      {
            // ����� ��������� � �������
      //      Debug.Log("HIT WITH BALL");
  //      }

    }

    public void hp (float damage)
    {
        text2.enabled = true;
        text2.text = $" - {damage}";
     //   Console.WriteLine($" - {damage}");
    }

}
