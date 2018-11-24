using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControll : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletHole;
    public float bulletSpeed = 1000f;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Shooting");

            Cursor.lockState = CursorLockMode.Locked;
            GameObject bullet = Instantiate(bulletPrefab, bulletHole.position, bulletHole.rotation);
            Debug.Log("Bullet created: " + bullet.transform.position);
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
            Destroy(bullet, 2);
        }
	}
}
