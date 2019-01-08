using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class ProgressBarController : MonoBehaviour {

    public static ProgressBarController instance;

    Image progressBarImage;

    void Awake ()
    {
        if (instance == null)
            instance = this;

        progressBarImage = GetComponent<Image>();
	}

    public void LoadingProgress(float progress)
    {
        progressBarImage.fillAmount = progress;
    }

    public void ResetProgressBar()
    {
        progressBarImage.fillAmount = 0;
    }
}
