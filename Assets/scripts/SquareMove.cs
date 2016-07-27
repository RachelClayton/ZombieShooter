using UnityEngine;
using System.Collections;

public class SquareMove : MonoBehaviour {

	public float mouseMoveSpeed = 5f;
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Mouse X"); //grab mouse input
		float vertical = Input.GetAxis("Mouse Y");
		 

		transform.position += new Vector3( horizontal, vertical, 0f ).normalized * Time.deltaTime * mouseMoveSpeed; //apply position to square
	}
}
