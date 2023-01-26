using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent pathfinder;
    public float maxDist = 15;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pathfinder = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform);
        

        
        
      pathfinder.SetDestination(player.transform.position);
        
    }
}
