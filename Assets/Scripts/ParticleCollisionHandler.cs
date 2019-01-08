using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleCollisionHandler : MonoBehaviour {

    public ParticleSystem particleSystem;
   

    int playerScore = 0;

    void Start ()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {

        Debug.Log("Particle collision: " + other.name);
          
    }

  
}
