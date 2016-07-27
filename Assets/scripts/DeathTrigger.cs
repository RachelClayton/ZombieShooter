using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public int damage = 100; 
	public GameObject player;


	//function that is automat called when something w/ a rgidbody enters this trigger
	void OnTriggerEnter2D( Collider2D activator ) {
		if ( activator.GetComponent<Killable>() != null ) { //is the thing killable?
			//potential todoL subract health from killablescript

			//but for now we destroy
			//Destroy( activator.gameObject ); 

		}
	}

	void OnTriggerStay2D( Collider2D activator ) {
		if ( ( activator.GetComponent<Killable>() != null ) && (GameObject.FindGameObjectWithTag ("Player")) )
		{
			activator.GetComponent<Killable>().Hurt( damage ); 
		} 
}
}


