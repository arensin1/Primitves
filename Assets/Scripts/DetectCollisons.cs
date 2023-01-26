using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    private GameObject player;
    public float nextHitTime = 3.0f;
    public int enemyHealth = 100;
    public int dmg = 1;
    private float nextHit;

    // Start is called before the first frame update
    void Start()
    {
        nextHit = Time.time;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Projectile")
        {
            enemyHealth -= 50;
            if (enemyHealth <= 0)
            {
                Destroy(gameObject);
            }
           
            Destroy(other.gameObject);
        }
        if (other.tag == "Player" && nextHit <= Time.time)
        {
            player.GetComponent<PlayerController>().currentHealth -= dmg;
           
            nextHit = Time.time + nextHitTime;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && nextHit <= Time.time)
        {
            player.GetComponent<PlayerController>().currentHealth -= dmg;
            
            nextHit = Time.time + nextHitTime;
        }
    }
}
