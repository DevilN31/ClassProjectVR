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
        GetComponent<BoxCollider>().enabled = showTrigger;

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Player")
        {

            scaryImage.canShowImage = true;
            scaryImage.StartCoroutine(scaryImage.StartScaryImage());

        }
    }
}
