using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = transform.forward * speed;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
             rb.velocity = transform.forward * speed;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
             rb.velocity = transform.forward * speed;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
             rb.velocity = transform.forward * speed;
        }
    }
}
