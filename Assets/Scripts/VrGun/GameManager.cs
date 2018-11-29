using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int cubeDestroyedCount;
    public ImageTrigger imageTrigger;

    // Use this for initialization
    void Start ()
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

    }
	
}
