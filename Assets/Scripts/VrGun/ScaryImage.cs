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


   public void ShowImage(bool showImage)
    {
        GetComponent<MeshRenderer>().enabled = showImage;
        GetComponent<MeshCollider>().enabled = showImage;

    }
}
