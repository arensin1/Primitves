using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public float start_delay = 5;
    public float spawn_interval = 3;
    public int startingEnemies = 10;
    private int count;
    private Transform[] spawnpoints;


    void Start()
    {
        //plane = GameObject.Find("Plane");
        InvokeRepeating("SpawnRandomEnemy", start_delay, spawn_interval);
        //for (int index = 0; index < startingEnemies; index++)
        //{
         //   SpawnRandomEnemy();
       // }
    }



    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        count = transform.childCount;
        spawnpoints = new Transform[count];
        for (int i = 0; i < count; i++)
        {
            spawnpoints[i] = transform.GetChild(i);
        }
        int randomIndex = Random.Range(0, enemies.Length);
        int randomSpawn = Random.Range(0, count);

        
        
        if (enemies.Length != 0)
        {
            Instantiate(enemies[randomIndex], spawnpoints[randomSpawn].position, Quaternion.identity);
        }
        
    }
    /*public Vector3 RandomNavmeshLocation()
    {
        
        Vector3 randomDirection = new Vector3(Random.Range(-25f, 25f), 0, Random.Range(-25f, 25f));
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, 25, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }*/
}
