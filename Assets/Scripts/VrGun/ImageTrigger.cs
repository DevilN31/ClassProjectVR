using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTrigger : MonoBehaviour {

    public bool showTrigger;
    public ScaryImage scaryImage;

    void Start()
    {
        showTrigger = false;
        ShowImageTrigger(showTrigger);
    }


   public void ShowImageTrigger(bool showTrigger)
    {
        GetComponent<MeshRenderer>().enabled = showTrigger;
        GetComponent<MeshCollider>().enabled = showTrigger;

    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Trigger hit");

        if (other.collider.tag == "Player")
        {
            Debug.Log("Player hit trigger");

            scaryImage.canShowImage = true;
            scaryImage.ShowImage(scaryImage.canShowImage);

        }
    }
}
