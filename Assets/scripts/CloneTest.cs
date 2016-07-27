using UnityEngine;
using System.Collections;

public class CloneTest : MonoBehaviour {

	public GameObject thingToClone;
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			//then make a new copy of thing at random point
			Instantiate( thingToClone, new Vector3( Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0f), Quaternion.Euler(0f, 0f, 0f) );
			//euler refers to 0-360 angles
				
		}
	}
} 