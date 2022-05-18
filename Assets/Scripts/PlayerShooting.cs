using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;


    public GameObject BulletPrefab;
    public GameObject cloneBullet;

    float timeTilShoot;
    

    public Transform shootPoint;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        timeTilShoot = Time.fixedDeltaTime + fireRate;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(BulletPrefab, shootPoint.position, Quaternion.identity);
        }
    }
}
