using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Vector2 moveVector; //automatically = newVector2(0f, 0f)
	Rigidbody2D myRigidbody; 

	public float moveSpeed = 5f; //allows it to show up in inspector

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal"); 
		float vertical = Input.GetAxis("Vertical");
		moveVector = new Vector2( horizontal, vertical ); 
		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized; //better way of norm
		}
			
	}

	void FixedUpdate () { //when physics run) so when we're not pressing anything

		myRigidbody.velocity = moveVector * moveSpeed; 
	}		
}
