using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeTracking : MonoBehaviour {

#if UNITY_EDITOR
    private void Start()
    {
        CreateParent();

        Input.gyro.enabled = true;

    }

    private static Quaternion GyroToUnity(Quaternion quaternion)
    {
        return new Quaternion(quaternion.x, quaternion.y, -quaternion.z, -quaternion.w);
    }

    private void GyroModifyCamera()
    {
        transform.localRotation = GyroToUnity(Input.gyro.attitude);
    }

    private void Update()
    {
        GyroModifyCamera();
    }

    private void CreateParent()
    {

        GameObject parent = new GameObject("Camera Root");
        parent.transform.localRotation = Quaternion.Euler(90, 0, 0);
        transform.parent = parent.transform;


        if (GameManager.instance.player != null)
            parent.transform.parent = GameManager.instance.player.transform;
    }

#endif
}
