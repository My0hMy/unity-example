using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float movespeed = 5;
    public float deadzone = -28;

   
    void Start()
    {
        

    }


    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime; 
        if (transform.position.x < deadzone )
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); }
    }
}
