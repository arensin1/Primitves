using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public float speed = 30.0f;
    public float xRange = 23;
    public float zRange = 23;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward* speed * Time.deltaTime, Space.World);
        if (transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zRange)
        {
           Destroy(gameObject);
        }
    }

}
