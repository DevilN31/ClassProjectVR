using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryImage : MonoBehaviour {

    public bool canShowImage;

    void Start()
    {
        canShowImage = false;
        ShowImage(canShowImage);
    }

	
	void Update ()
    {
        if(GameManager.instance.cubeDestroyedCount >= 5)
        {
            canShowImage = true;
        }

        if (canShowImage)
        {
            ShowImage(canShowImage);
        }	
	}

    void ShowImage(bool showImage)
    {
        GetComponent<MeshRenderer>().enabled = showImage;
        GetComponent<MeshCollider>().enabled = showImage;


    }
}
