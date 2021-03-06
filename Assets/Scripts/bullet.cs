using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D bulletRb;
    float bulletSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //bulletRb.AddForce(Vector2.right * bulletSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);

        transform.position += transform.right * Time.fixedDeltaTime * bulletSpeed;
        
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject, 1f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       /* if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            
        }*/

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

    }

    
}
