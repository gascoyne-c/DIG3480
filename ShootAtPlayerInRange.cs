using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayerInRange : MonoBehaviour
{
    public GameObject enemyFire;

    public PlayerController player;
    public Transform firePoint;

    public float playerRange;
    public float waitBetweenFire;
    private float fireCounter;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        fireCounter = waitBetweenFire;
    }

    void Update()
    {
        fireCounter -= Time.deltaTime;

        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && fireCounter < 0)
        {
            Instantiate(enemyFire, firePoint.position, firePoint.rotation);
            fireCounter = waitBetweenFire;
        }


        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && fireCounter < 0)
        {
            Instantiate(enemyFire, firePoint.position, firePoint.rotation);
            fireCounter = waitBetweenFire;
        }

    }
}

