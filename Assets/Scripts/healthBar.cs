using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBar : MonoBehaviour
{
    private Image healthSlider;

    float health = 5f; //total full health player has
    float currentHealth = 5f; // current health player has
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

    void OnCollisionEnter2D(Collision2D other) //needs to be applied to enemy bullet
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentHealth = health - 1f; // enemy does one damage to player due to touching them
            healthSlider.fillAmount = currentHealth / health;
        }
        else if (health<0){
            Destroy(this.gameObject);            //player is dead and respawned if the have zero health
            SceneManager.LoadScene("SampleScene");
        }
    }

}
