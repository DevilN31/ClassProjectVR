using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int speed = 10;
    Rigidbody rig;
    public Transform playerCamera;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void  FixedUpdate()
    {       
        
        if (Input.GetKey("joystick 1 button 1"))
        {
            rig.MovePosition(transform.position + playerCamera.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey("joystick 1 button 2"))
        {
            rig.AddExplosionForce(100,transform.position,5,1,ForceMode.Impulse);
            Debug.Log("jump");
        }
    }
}
