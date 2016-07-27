using UnityEngine;
using System.Collections;

public class ZomClone : MonoBehaviour {
	public GameObject Zombie;

	// Use this for initialization
	void Start () {

		InvokeRepeating("CloneZombie", 5, 2F);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void CloneZombie () {
		Instantiate (Zombie, new Vector3( Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0f), Quaternion.Euler(0f, 0f, 0f) );
	}
		

}
