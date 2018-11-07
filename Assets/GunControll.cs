using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControll : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletHole;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletHole.position, bulletHole.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1000);
            Destroy(bullet, 2);
        }
	}
}
