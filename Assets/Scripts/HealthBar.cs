using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    private Slider slider;
    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;
    }

    public void Init(){
        slider = GetComponent<Slider>();
    }
    public void Sethealth(float health) {
        slider.value =health;
    }

    public Slider GetSlider()
    {
        return this.slider;
    }
}