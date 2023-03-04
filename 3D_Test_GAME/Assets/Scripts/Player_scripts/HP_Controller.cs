using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HP_Controller : MonoBehaviour
{
    private Slider health_bar;

    void Start()
    {
        health_bar = GetComponent<Slider>();
        health_bar.maxValue = Player.health_max;
        health_bar.value = Player.health;
    }

    void Update()
    {
        health_bar.maxValue = Player.health_max;
        health_bar.value = Player.health;
    }

}
