using UnityEngine;
using System.Collections;

public class MouseToLook : MonoBehaviour {

	public Transform player; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint( Input.mousePosition ); //converts mouse pixel coordinate to 3d world coordinate
		cursorPositionInWorld.z = 0f;
		Vector3 lookDirection = cursorPositionInWorld - player.position;
		lookDirection.z = 0f;
		player.up = lookDirection;



	}
}
