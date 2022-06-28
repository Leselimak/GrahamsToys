using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{
    public int healthMax = 10;
    public int healthCurrent;
    private SpriteRenderer richardsSprite; 
    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
        richardsSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void HitPoints( int damage)
    {
        healthCurrent -= damage;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            HitPoints(1);
        }

        if(healthCurrent == 0)
        {
            SceneManager.LoadScene("StoryThree");
        }
        /*if (other.gameObject.tag == "Wall")
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            richardsSprite.flipX = true;
            
        }*/

    }
}
