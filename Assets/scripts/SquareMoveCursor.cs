using UnityEngine;
using System.Collections;

public class SquareMoveCursor : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint( Input.mousePosition ); //converts mouse pixel coordinate to 3d world coordinate

		//set z of worldpoint to 0 (so camera can see)
		cursorPositionInWorld.z = 0f;
		//0 = left, 1 = right click, 2 = middle click
		if ( Input.GetMouseButtonDown(0) ) {
		transform.position = cursorPositionInWorld;
		//teleport this gameobject to where cursor is
	} 
} 
}
