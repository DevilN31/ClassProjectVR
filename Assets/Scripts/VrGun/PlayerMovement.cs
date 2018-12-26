using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int speed = 10;
    Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        /*
        RaycastHit hit;

        if (Input.GetKeyDown("joystick 1 button 1"))
        {
            
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                transform.position = hit.point;
            }
            

        }
        */
        
        
        if (Input.GetKey("joystick 1 button 1"))
        {
             transform.position += transform.forward * speed * Time.deltaTime;
            Debug.Log("Player moved to: " + transform.position + " Speed: : " + speed);
        }
        
       
    }
}
