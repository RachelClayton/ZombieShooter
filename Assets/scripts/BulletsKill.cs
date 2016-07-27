using UnityEngine;
using System.Collections;

public class BulletsKill : MonoBehaviour {

	public int damage = 100;

	void OnTriggerEnter2D( Collider2D activator ) {
		if ( activator.gameObject.tag == "Zombie") {
			Destroy(activator.gameObject);
			Destroy(gameObject);

		}
	}
//		void OnCollisionStay2D( Collision2D activator ) {
//			if ( activator.gameObject.GetComponent<Killable>() !=null ) {
//				Destroy( activator.gameObject );
//
//			}
//		}
}
