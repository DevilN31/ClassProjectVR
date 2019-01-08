using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroGameManager : MonoBehaviour {

    public static GyroGameManager instance;
    [System.NonSerialized]
    public Transform cameraTransform;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        cameraTransform = Camera.main.transform;
    }

    void OnEnable()
    {
        //   LookHandler.OnLookAtAction += EnableTouch;
    }

    void OnDisable()
    {
        // LookHandler.OnLookAtAction -= EnableTouch;
    }

   public void EnableTouch(bool isLooking)
    {
        Debug.Log(isLooking);
        InputManager.instance.ListenToTouchInput(isLooking);
    }
    
   public void LoadBar()
    {
        ProgressBarController.instance.LoadingProgress(InputManager.instance.timer);
    }
    


 
}
