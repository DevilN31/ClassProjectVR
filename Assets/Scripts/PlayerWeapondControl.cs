using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWeapondControl : MonoBehaviour {

    ParticleCollisionHandler particleCollision;

    [Range(0.3f, 3)]
    public float shootSpeed = 0.5f;
    float lastShot;

    void Start()
    {
        particleCollision = GetComponentInChildren<ParticleCollisionHandler>();
        lastShot = Time.time;
    }

    void Update ()
    {
        if (Input.GetKeyDown("joystick 1 button 4"))
        {
            Debug.Log("Shoot attemp detected");
            AttemptShoot(shootSpeed);
        }
    }

    void AttemptShoot(float shootSpeed)
    {
       
        particleCollision.particleSystem.Emit(1);
        lastShot = Time.time;
    }
    
}
