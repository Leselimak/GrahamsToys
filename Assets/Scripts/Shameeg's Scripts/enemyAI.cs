using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Transform groundDetectionObj; //attach detectObj to it by dragging it into the component within the enemy obj
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetectionObj.position, Vector2.down, 2f); //raycast is like a sun beam poining down, detects if there is ground

        if (groundInfo.collider == false) //the enemy cube will move opposite if the ground is not detected
        {                                   // diamond(detectObj) is apart of the enemy object now
            transform.Rotate(0f, 180f, 0f);
        }
    }

    void Move()
    {
        transform.Translate(Vector2.right * 4.0f * Time.deltaTime);
    }
}
