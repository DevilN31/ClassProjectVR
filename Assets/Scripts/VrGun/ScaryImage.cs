using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ScaryImage : MonoBehaviour {

    public bool canShowImage;
  //  public Light spotLight;
    

    void Start()
    {
        canShowImage = false;
        ShowImage(canShowImage);
    }


   public void ShowImage(bool showImage)
    {

        //GetComponent<MeshRenderer>().enabled = showImage;
        // GetComponent<MeshCollider>().enabled = showImage;
        GetComponent<RawImage>().enabled = showImage;
        GetComponent<VideoPlayer>().enabled = showImage;
        GetComponent<VideoPlayer>().Play();
      //  spotLight.enabled = showImage;

    }

    public IEnumerator StartScaryImage()
    {
        ShowImage(canShowImage);
        yield return new WaitForSeconds((float) GetComponent<VideoPlayer>().clip.length);
        canShowImage = false;
        ShowImage(canShowImage);
    }
}
