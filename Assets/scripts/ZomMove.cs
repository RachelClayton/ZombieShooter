using UnityEngine;
using System.Collections;

public class ZomMove : MonoBehaviour {

	public Transform destination;
	public float zomSpeed = 5;
	void Start () {
		destination = GameObject.FindGameObjectWithTag ("Player").transform;
	}



	// Update is called once per frame
	void Update () {	
		
		if ( (destination != null) && ( Vector3.Distance( transform.position, destination.position ) > 0.25f ) ) {
	//make behavior frame rate independent 
		transform.position += Vector3.Normalize(destination.position - transform.position) * Time.deltaTime * zomSpeed;
	
		}
}

//	void OnDrawGizmos () { //icons and handles on sprites n things
//		Gizmos.DrawLine( transform.position, destination.position );
//	}
}