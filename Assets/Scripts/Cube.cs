using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Debug.Log(this.name + " Killed");
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
    }
}
