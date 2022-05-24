using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Pathfinding;

public class enemy : MonoBehaviour
{

    public float speed;

    bool movingRight = true;

    public Transform groundDetection;
    private SpriteRenderer enemySprite;
    private Animator enemyAnim;
   // public Transform target;
   // public float nextWayPointDistance = 3f;

  //  Path path;
  //  int currentWayPoint = 0;
   // bool reachedEndOfPath = false;

    //Rigidbody2D EnemyRb;
    //Seeker seekr;

    void Start()
    {
        enemySprite = GetComponent<SpriteRenderer>();
        enemyAnim = GetComponent<Animator>();
       // EnemyRb = GetComponent<Rigidbody2D>();
      //  seekr = GetComponent<Seeker>();

       // seekr.StartPath(EnemyRb.position, target.position, OnPathComplete);

    }

   /* void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWayPoint = 0;
        }

    }*/



    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f); // Raycast send laser downwards and detects edge from the point of origin which is a empty game object.

        /*if (path == null)
            return;

        if (currentWayPoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - EnemyRb.position).normalized;
        Vector2 force = direction * speed * Time.fixedDeltaTime;

        EnemyRb.AddForce(force);

        float distance = Vector2.Distance(EnemyRb.position, path.vectorPath[currentWayPoint]);

        if(distance < nextWayPointDistance)
        {
            currentWayPoint++;
        }*/
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
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

        if (other.gameObject.tag == "Bed")
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

        if(other.gameObject.tag == "Bullet")
        {
            enemyAnim.SetBool("isDying", true);
            Destroy(this.gameObject);
        }
        else
        {
            enemyAnim.SetBool("isDying", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    } // Enemy collides with player and the player respawns.

   

 
}