using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public PlayerController player;
    //public GameObject impactEffect;

    public float speed;
    //public float rotationSpeed;

    private Rigidbody2D rb2d;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        rb2d = GetComponent<Rigidbody2D>();
        
        if(player.transform.position.x < transform.position.x)
        {
            speed = -speed;
            //rotationSpeed = -rotationSpeed;
        }
    }

    private void Update()
    {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        //rb2d.angularVelocity = rotationSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Instantiate(impactEffect, transform.position, transform.rotation);
        //Destroy(gameObject);
    }
}
