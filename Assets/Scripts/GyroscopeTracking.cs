using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeTracking : MonoBehaviour {

#if UNITY_EDITOR  
    private void Awake()
    {
        GameObject _parent = new GameObject("CameraRoot");
        _parent.transform.rotation = Quaternion.Euler(90, 0, 0);
        transform.parent = _parent.transform;
    }

	// Use this for initialization
	void Start ()
    {
        Input.gyro.enabled = true;
	}

    void GyroModifyCamera()
    {
        transform.localRotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }

    // Update is called once per frame
    void Update ()
    {
        //transform.rotation = Input.gyro.attitude;	
        GyroModifyCamera();

    }
#endif
}
