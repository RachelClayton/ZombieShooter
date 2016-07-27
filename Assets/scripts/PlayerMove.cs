using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// if player holds W, goes up
		if ( Input.GetKey( KeyCode.W ) ) { 
			transform.position += new Vector3( 0f, 5f, 0f ) * Time.deltaTime; //timedeltatime is duration of the frame in seconds
			// if 10 fps, deltatime is 0.1f
			// if 100 fps, deltatime is 0.01f
			Debug.Log( transform.position.y ); // reading the Y is ok
		}

		if ( Input.GetKey( KeyCode.S ) ) { 
			transform.position += new Vector3( 0f, -5f, 0f ) * Time.deltaTime; //timedeltatime is duration of the frame in seconds
			// if 10 fps, deltatime is 0.1f
			// if 100 fps, deltatime is 0.01f
			Debug.Log( transform.position.y ); // reading the Y is ok
		}

		if ( Input.GetKey( KeyCode.A ) ) { 
			transform.position += new Vector3( -5f, 0f, 0f ) * Time.deltaTime; //timedeltatime is duration of the frame in seconds
			// if 10 fps, deltatime is 0.1f
			// if 100 fps, deltatime is 0.01f
			Debug.Log( transform.position.x ); // reading the Y is ok
		}

		if ( Input.GetKey( KeyCode.D ) ) { 
			transform.position += new Vector3( 5f, 0f, 0f ) * Time.deltaTime; //timedeltatime is duration of the frame in seconds
			// if 10 fps, deltatime is 0.1f
			// if 100 fps, deltatime is 0.01f
			Debug.Log( transform.position.x ); // reading the Y is ok
		}
	
	} //end update bracket
}
