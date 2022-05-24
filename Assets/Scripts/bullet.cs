using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D bulletRb;
    float bulletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        bulletRb.AddForce(Vector2.right * bulletSpeed *Time.fixedDeltaTime, ForceMode2D.Impulse);
       
    }

    /*void OnCollisionEnter2D(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            
        }*


    }*/

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
