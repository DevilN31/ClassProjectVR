using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {


    public static InputManager instance;
    public float maxDealy = 1f;
    public float timer = 0;
    private bool currentTouchDetected = false;

    [SerializeField]
     bool getInput;

    public delegate void TouchAction();
    public  event TouchAction OnLongTouchEvent;
    public  event TouchAction OnSingleTapEvent;
    public event TouchAction OnDoubleTapEvent;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else
            Destroy(this);

        DontDestroyOnLoad(gameObject);

    }

    void Update () 
    {
        GetInput();
    }

    void GetInput()
    {
        if (getInput)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.touches[0];
                TouchPhase phase = touch.phase;

                switch (phase)
                {
                    case TouchPhase.Began:

                        break;

                    case TouchPhase.Ended:
                        if (timer < maxDealy)
                        {
                            if (touch.tapCount == 2)
                            {
                                if (OnDoubleTapEvent != null)
                                    OnDoubleTapEvent();
                            }
                            else
                            {
                                if (OnSingleTapEvent != null)
                                    OnSingleTapEvent();
                            }

                        }

                        timer = 0;
                        ProgressBarController.instance.ResetProgressBar();
                        currentTouchDetected = false;

                        break;

                    default:
                        if (!currentTouchDetected)
                        {
                            timer += Time.deltaTime;

                            ProgressBarController.instance.LoadingProgress(timer);

                            if (timer >= maxDealy)
                            {
                                if (OnLongTouchEvent != null)
                                    OnLongTouchEvent();

                                currentTouchDetected = true;
                            }
                        }
                        break;
                }

            }
        }
    }

    public void ListenToTouchInput( bool listen)
    {
        getInput = listen;
    }

}
