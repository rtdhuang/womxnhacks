using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //this is for to call it rigidBody

    public float forwardForce = 200f;
    public float sidewaysForce = 500f;

    // FixedUpdate is to mess with Unity Physics 
    void FixedUpdate() //people just like it 
    {
        //Add a forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
