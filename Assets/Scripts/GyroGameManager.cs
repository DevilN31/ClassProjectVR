using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        LookHandler.OnLookAtAction += PrintTargetName;
    }

    void OnDisable()
    {
        LookHandler.OnLookAtAction -= PrintTargetName;
    }
    void PrintTargetName(bool isLooking, string targetName)
    {
        if(isLooking)
        Debug.Log("Hit: " + targetName);
    }
}
