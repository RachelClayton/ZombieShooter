using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	public Rigidbody2D bullet; 
	public Rigidbody2D bulletClone;
	public float bulletspeed = .00000005f;
	// Use this for initialization
	void Start () {
	
	}

	void FireBullet () {
		Rigidbody2D bulletClone = (Rigidbody2D) Instantiate(bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.up * bulletspeed;

		bulletClone.GetComponent<BulletMove>();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) ) {
			FireBullet();
		}
	}
}
