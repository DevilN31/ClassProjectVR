﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteract : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {
        CastRay();
	}

    void CastRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit))
        {
            if (hit.collider.GetComponent<LookHandler>())
            {
                hit.collider.GetComponent<LookHandler>().Bounce(hit.collider.GetComponent<LookHandler>().isGrounded);
                if (hit.collider.GetComponent<LookHandler>().isGrounded)
                    StartCoroutine(GayMaterial(hit.collider.GetComponent<LookHandler>().material));
                hit.collider.GetComponent<LookHandler>().isGrounded = false;
                
            }
        }
    }

    IEnumerator GayMaterial(Material m)
    {

        m.color = Color.red;
        yield return new WaitForSeconds(0.5f);

        m.color = Color.yellow;
        yield return new WaitForSeconds(0.5f);

        m.color = Color.green;
        yield return new WaitForSeconds(0.5f);

        m.color = Color.blue ;
        yield return new WaitForSeconds(0.5f);

        m.color = Color.white;      
    }
}
