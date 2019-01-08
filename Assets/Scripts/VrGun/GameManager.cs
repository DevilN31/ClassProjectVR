using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int cubeDestroyedCount;
    public ImageTrigger imageTrigger;

    public GameObject player;

    void Awake ()
    {
        if(instance == null)
        {
            instance = this;
        }

        cubeDestroyedCount = 0;
	}

    void Update()
    {
        if(cubeDestroyedCount >= 5)
        {
            imageTrigger.showTrigger = true;
            imageTrigger.ShowImageTrigger(imageTrigger.showTrigger);
        }

        if (Input.GetKeyDown("joystick 1 button 0"))
        {
            Application.Quit();
        }        
    }
	
}
