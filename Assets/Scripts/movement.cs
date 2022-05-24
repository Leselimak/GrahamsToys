using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float FireRate = 2.5f;

    public Transform FirePoint;
    public GameObject BulletPrefab;
    float timeTillFire;
    bool aPressed, sPressed, dPressed, spacePressed; // input booleans to check when buttons are being engaged.

    float Speed = 15f; // movement speed float. This number can be anything but 15 seems to work well for the purpose of this assignment.

    Rigidbody2D playerRB; // referencing the Rigidbody and declaring that it is going to be used in a variable called "playerRB".
    private SpriteRenderer grahamSprite;
    private Animator grahamAnim;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); // accessing the Rigidbody on the player.
        grahamSprite = GetComponent<SpriteRenderer>();
        grahamAnim = GetComponent<Animator>();
       
    }

    void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            aPressed = true;
            grahamSprite.flipX = true;
           
        }
        else
        {
            aPressed = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            sPressed = true;
        }
        else
        {
            sPressed = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dPressed = true;
            grahamSprite.flipX = false;
            
        }
        else
        {
            dPressed = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            spacePressed = true;
        }
        else
        {
            spacePressed = false;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    } /* accessing the player's keyboard buttons, with "GetKey(KeyCode.*)" and linking them to their respective booleans that were declared earlier.
       another effective variation of the get key is by differentiating between GetKeyUp and GetKeyDown. Sometimes a player might need that choice.*/


    // Update is called once per frame
    void Update()
    {
        KeyboardInput(); // calling the KeyboardInput Method, once per frame because these inputs must be checked every second. 
        Shoot();
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void FixedUpdate() // To be checked or called upon once per frame but this method is specifically for functions that make use of physics
    {
        Move(); // calling the Move method.
        timeTillFire = Time.fixedDeltaTime + FireRate;
    }


    void Move()
    {
        if (aPressed)
        {
            transform.Translate(-Speed * Time.fixedDeltaTime, 0, 0); // move left hence the negative x-value.
           

        }

        if (sPressed)
        {
            transform.Translate(0, -Speed * Time.fixedDeltaTime, 0);// move down hence the negative y-value. This is not essential because we also have gravity.
        }

        if (dPressed)
        {
            transform.Translate(Speed * Time.fixedDeltaTime, 0, 0);// move right.k
                      
        }

        if (spacePressed)
        {
            transform.Translate(0, Speed * Time.fixedDeltaTime, 0);// move up.
      
        }
        else
        {
           
        }

        if (!aPressed && !dPressed && !spacePressed && !sPressed)
            
        {
            
           
        }
        else
        {
          

        }

       if(aPressed || dPressed)
        {
           
        }
      

    } /* The transform method was used because the player object has a built in transform component that can be accessed without 
         having to reference it first as was the case with the Rigibody. The component is accessed and then the Translate function is
         used on it which moves the player object relative to an amount; this amount is the float variable called 'Speed' in this case.

         Using AddForce can be looked at with the context of Newton's 2nd law, where a vector (force) is added to the player object and it 
         would move within the game world until an outside force made it not move anymore. This outside force is friction in this case.
         After sliding for a distance the player eventually comes to a halt; whereas transform.Translate moves the player object from point a 
         to point b and this prevents the sliding effect that is seen otherwise, even when the player holds a button down for any amount of time. 
         The player object will be disposed by 'Speed' amount of units relative to how long a button is pressed. 
    
         It was also imperative to use Time.fixedDeltaTime because it takes into account and regulates the different processing speeds of 
         computers so as to keep the player object from jittering or moving to fast. Time.fixedDeltaTime takes the reference of time from 
         most previous FixedUpdate call as opposed to time.deltaTime where time references can vary between frames. */

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        /* if(other.gameObject.tag == "Enemy")
         {
             Destroy(this.gameObject);
             SceneManager.LoadScene("SampleScene");
         }*/

        if (other.gameObject.tag == "Bed")
        {
            if (spacePressed)
            {
                transform.Translate(0, Speed * Time.fixedDeltaTime, 0);// move up.
                grahamAnim.SetBool("isJumping", true);
            }
            else
            {
                spacePressed = false;
            }
        }



    }

    private void OnTriggerEnter2D(Collider2D other
        )
    {
        if (other.gameObject.tag == "Collectible")
        {
            Destroy(other.gameObject);
        } 
}
}