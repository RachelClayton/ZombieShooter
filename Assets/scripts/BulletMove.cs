using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {


	// Use this for initialization
	IEnumerator Start () {
	yield return new WaitForSeconds(5);
		KillSelf();
	}
	void KillSelf() {
	Destroy( gameObject ); 
	}
	// Update is called once per frame
	void Update () {
	
	}
}
