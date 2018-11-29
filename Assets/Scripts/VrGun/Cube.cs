using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            GameManager.instance.cubeDestroyedCount++;
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
    }
}
