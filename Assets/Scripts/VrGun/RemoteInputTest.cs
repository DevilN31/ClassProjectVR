using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteInputTest : MonoBehaviour
{

    void Update()
    {
        for (int i = 0; i < 20; i++)
        {
            if (Input.GetKeyDown("joystick 1 button " + i.ToString()))
            {
                Debug.Log("joystick 1 button " + i.ToString());
            }
        }
    }
}
