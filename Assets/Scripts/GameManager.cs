using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public int cubeDestroyedCount;

    // Use this for initialization
    void Start ()
    {
        if(instance == null)
        {
            instance = this;
        }

        cubeDestroyedCount = 0;
	}
	
}
