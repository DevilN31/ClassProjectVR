using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookHandler : MonoBehaviour {

    private Transform cameraTransform;
    float deltaDegrees;

    void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

	// Use this for initialization
	void Start () {
		
	}
	
    void HandleLookAt()
    {
        Vector3 camToMe = (transform.position - cameraTransform.position).normalized;
        Vector3 camForward = cameraTransform.forward;

        Debug.DrawRay(cameraTransform.position, camToMe * 10, Color.green);
        Debug.DrawRay(cameraTransform.position, camForward * 10, Color.red);

         deltaDegrees = Vector3.Angle(camToMe, camForward);
    }

	// Update is called once per frame
	void Update ()
    {
        HandleLookAt();	
	}

    void OnGUI()
    {
        GUILayout.Label("Degrees: " + deltaDegrees);
    }
}
