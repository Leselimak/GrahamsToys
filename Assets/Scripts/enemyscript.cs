using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyscript : MonoBehaviour
{
    public float speed;

    bool movingRight = true;

    public Transform groundDetection;
    private SpriteRenderer enemySprite;
    private Animator enemyAnim;

    void Start()
    {
        enemySprite = GetComponent<SpriteRenderer>();
        enemyAnim = GetComponent<Animator>();
    }



    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f); // Raycast send laser downwards and detects edge from the point of origin which is a empty game object.

        /*if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false; //Enemy patrols and turns around at the edge of the platform
                enemySprite.flipX = false;
                enemyAnim.SetBool("isWalking", true);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true; // Enemy just keeps patrolling
                enemySprite.flipX = true;
                enemyAnim.SetBool("isWalking", false);
            }
        }*/

       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        /* if (other.gameObject.tag == "Wall")
         {
             print("collision");
             transform.Translate(Vector2.left * speed * Time.deltaTime);
         }

         else if (other.gameObject.tag == "Ground")
         {
             transform.Translate(Vector2.right * speed * Time.deltaTime);
         }
         else
         {
             transform.Translate(Vector2.right * speed * Time.deltaTime);
         }*/
        if (other.gameObject.tag == "Wall")
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
           // movingRight = false; //Enemy patrols and turns around at the edge of the platform
            enemySprite.flipX = true;
            enemyAnim.SetBool("isWalking", true);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            //movingRight = true; // Enemy just keeps patrolling
            enemySprite.flipX = true;
            enemyAnim.SetBool("isWalking", true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    } // Enemy collides with player and the player respawns.

   

    /*void OnTriggerStay(Collider other)
      {
            if(groundDetection.gameObject.tag == "Ground")
          {
              transform.eulerAngles = new Vector3(0, 0, 0);

          }
          else
          {
              transform.eulerAngles = new Vector3(0, -180, 0);
          }
      }*/
}