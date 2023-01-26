using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float hortizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float xRange =  20;
    public float zRange = 20;
    public float shootSpeed = 30.0f;
    public int maxHealth = 100;
    public int currentHealth = 100;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //attack
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        
            //projectilePrefab.velocity = transform.up * shootSpeed;
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        hortizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hortizontalInput, 0.0f, verticalInput);
        transform.LookAt(movement + transform.position);
        //transform.rotation = Quaternion.LookRotation(movement);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }
}
