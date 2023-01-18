

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc1 : MonoBehaviour
{
    Rigidbody rb;
    float Mvspeed=2f;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
      //Debug.Log("helllo from start");
    }

    // Update is called once per frame

    void Update()
    {

float horizontalInput=Input.GetAxis("Horizontal");
float verticalInput=Input.GetAxis("Vertical");


rb.velocity=new Vector3(horizontalInput * Mvspeed, rb.velocity.y, verticalInput * Mvspeed);
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(rb.velocity.x,2f,rb.velocity.z);
        }
        transform.Rotate(0,Input.GetAxis("Mouse X"),0);
        /*if(Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0,0,2);
        }
        if(Input.GetKey("right"))
        {
           rb.velocity = new Vector3(2,0,0);
        }
        if(Input.GetKey("left"))
        {
           rb.velocity = new Vector3(-2,0,0);
        }
    
         if(Input.GetKeyDown("down"))
        {
            rb.velocity = new Vector3(0,0,-2);
        }*/
        

    }
}
