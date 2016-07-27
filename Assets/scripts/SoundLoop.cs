using UnityEngine;
using System.Collections;

public class SoundLoop : MonoBehaviour {

	AudioSource myAudio;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown (KeyCode.L) ) {
			if ( myAudio.isPlaying ) {
				myAudio.Stop();
			} else {
				myAudio.loop = true;
				myAudio.Play();
			}
		}
	}
}
