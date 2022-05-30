using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{

    Rigidbody2D bulletRB;
    float bulletSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += - transform.right * Time.fixedDeltaTime * bulletSpeed;
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject, 1f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
     
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }

    }
}
