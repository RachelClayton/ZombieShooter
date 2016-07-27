using UnityEngine;
using System.Collections;

public class ClickToClone : MonoBehaviour {

	public GameObject thingToClone;
	
	// Update is called once per frame
	void Update () {
		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		cursorPositionInWorld.z = 0f;

		if ( Input.GetMouseButtonDown(0) ) {
			Instantiate( thingToClone, cursorPositionInWorld, Quaternion.Euler(0f, 0f, 0f) );
		}
	}

}
