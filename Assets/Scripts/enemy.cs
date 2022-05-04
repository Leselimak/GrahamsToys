using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public float speed;

    private bool movingRight = true;

    public Transform groundDetection;





    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f); // Raycast send laser downwards and detects edge from the point of origin which is a empty game object.

        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false; //Enemy patrols and turns around at the edge of the platform
            }
            /*else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true; // Enemy just keeps patrolling
            }*/
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