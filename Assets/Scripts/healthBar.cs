using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Image healthSlider;

    float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (health < 100f)
            {
                health += 10f;
            }
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            if (health > 0f)
            {
                health -= 10f;
            }
        }

        healthSlider.fillAmount = health / 100f;
    }

    
}
