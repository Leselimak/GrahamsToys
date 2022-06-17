using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    bool aPressed, dPressed;
    Rigidbody2D cameraRB;
    float movementSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        cameraRB = GetComponent<Rigidbody2D>();
    }

    void KeysInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
          
            aPressed = true;
           

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            aPressed = false;
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
         
            dPressed = true;
       

        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            dPressed = false;
           

        }
    }
         

// Update is called once per frame
void Update()
    {
        KeysInput(); 
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        if (aPressed)
        {

            transform.Translate(-movementSpeed * Time.fixedDeltaTime, 0, 0); // move left hence the negative x-value.
         

        }
        if (dPressed)
        {

            transform.Translate(movementSpeed * Time.fixedDeltaTime, 0, 0); // move right.


        }
    }
}
