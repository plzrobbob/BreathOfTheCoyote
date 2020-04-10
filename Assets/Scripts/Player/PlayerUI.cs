﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//This is the slider for the health bar used in game will be called in player script when damage is done to player
public class PlayerUI : MonoBehaviour
{
    private Slider HealthSlider;

    // Start is called before the first frame update
    void Start()
    {
        HealthSlider = GameObject.Find("Health_Slider").GetComponent<Slider>();
        //Debug.Log("Initial Value: " + HealthSlider.value);
    }

    public void OnSliderValueChanged(float value)
    {
        HealthSlider.value = value;
    }

    public void UpdateSlider(float health)
    {
        HealthSlider.value = health;
        //Debug.Log("Health Slider: " + HealthSlider.value);
    }
}
