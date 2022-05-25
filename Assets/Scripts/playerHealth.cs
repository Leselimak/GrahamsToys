using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public Slider hpSlider;

    public void setMaxHealth(int Health)
    {
        hpSlider.maxValue = Health;
        hpSlider.value = Health;
    }

   public void setHealth(int Health)
    {
        hpSlider.value = Health;
    }
}
