using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookHandler : MonoBehaviour {

    public Material material;
    bool didLookAtMeLastFrame;
    public bool isGrounded;

    float _deltaDegrees;

	//max angle to determine if camera is looking at me
    float maxFocusDegrees = 10;

    //is the camera looking at me? 
    bool isLookingAtMe { get { return (deltaDegrees < maxFocusDegrees); } }
	
    float deltaDegrees
    {
        get { return _deltaDegrees; }
        set
        {
            //instead of checking if looking at me at every frame, check only if camera moved/rotated 
            if (value != _deltaDegrees)
            {
                _deltaDegrees = value;

                //TODO: check if looking at me....next class
                DegreeValueChange();
            }
        }
    }

    private void Awake()
    {
        //reference to the camera's transform
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
      //  HandleLookAt();
    }
	
	void HandleLookAt()
    {
        
        //create a vector that is the forward vector (z axis in world space) of the camera
        Vector3 camForward = GyroGameManager.instance.cameraTransform.forward;
        //create a vector that is the direction from the camera to me
        Vector3 camToMe = (transform.position - GyroGameManager.instance.cameraTransform.position).normalized;

        //show them in the scene view only
        Debug.DrawRay(GyroGameManager.instance.cameraTransform.position, camForward * 3, Color.red);
        Debug.DrawRay(GyroGameManager.instance.cameraTransform.position, camToMe * 3, Color.green);

        //calculate angle between the two vectors
        deltaDegrees = Vector3.Angle(camToMe, camForward);
    }
	
	 private void DegreeValueChange()
    {
        if (isLookingAtMe && !didLookAtMeLastFrame)
        {
            isGrounded = false;

            // ChangeColor(Color.red);
            Bounce(isGrounded);
            if (OnLookAtAction != null)
                OnLookAtAction(true);
        }
        else if(!isLookingAtMe && didLookAtMeLastFrame)
        {
            if (OnLookAtAction != null)
                OnLookAtAction(false);
        }

        didLookAtMeLastFrame = isLookingAtMe;
    }

    void ChangeColor(Color color)
    {
        material.color = color;
    }


    private void OnGUI()
    {
        GUILayout.Label("deltaDegrees = " + deltaDegrees.ToString());
    }

    public delegate void LookAtAction(bool isLookingAtMe);
    public static event LookAtAction OnLookAtAction;

    public void Bounce(bool isInAir)
    {
        if(isInAir)
        GetComponent<Rigidbody>().AddExplosionForce(500, transform.position, 1f);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Finish")
        {
            isGrounded = true;
        }
    }

}
