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
    public float heightOffset = 10;
    public float Noman = -45;

    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime; 
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }

    if (transform.position.x < Noman){
    Debug.Log("Pipe deleted");
    Destroy(gameObject);
}

    }

    void SpawnPipe()
    { 
         float lowestpoint = transform.position.y - heightOffset;
          float highestpoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint, highestpoint), 0), transform.rotation); 
    }
   


}

