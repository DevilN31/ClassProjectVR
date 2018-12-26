using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * 
 * 
 * 
 * TESTING RESULTS:
 * 1) RIGHT SHIFTER: JOYSTICK 1 BUTTON 1
 * 2) LEFT SHIFTER: JOYSTICK 1 BUTTON 0
 * 3) TO ACCESS INPUT: DONT USE INPUT MANAGER. USE: Input.GetKey("joystick " + joystick + " button " + button)
 * 
 * 
 * 
 * */
public class TestJoystickInput : MonoBehaviour {

	
	void Update () {
        for (int joystick = 1; joystick < 5; joystick++ ) {
            for (int button = 0; button < 20; button++ ) {
                if (Input.GetKey("joystick " + joystick + " button " + button))
                {
                    Debug.Log("joystick = " + joystick + "  button = " + button);
                }
            }
        }

    }

  
}
