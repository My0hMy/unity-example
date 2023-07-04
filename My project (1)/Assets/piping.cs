using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;


public class piping : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime; 
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    { 
        Instantiate(pipe, transform.position, transform.rotation); }
   
    
   
}

