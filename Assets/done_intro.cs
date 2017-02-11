using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class done_intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource audio = GameObject.Find("Nar1").GetComponent<AudioSource>();

		if (!audio.isPlaying) {
			Debug.Log ("HELLO");
			Camera camM = GameObject.Find("Nar1").GetComponent<Camera>();
			camM.enabled = false;
			Camera camM2 = GameObject.Find("MainCamera").GetComponent<Camera>();
			camM2.enabled = true;

			AudioSource audio2 = GameObject.Find("Nar2").GetComponent<AudioSource>();
			//AudioSource.PlayClipAtPoint (audio2.clip, 0);

			audio2.volume = 1.0f;

			AudioSource.PlayClipAtPoint(audio2.clip, new Vector3(5, 1, 2),50f);

			this.enabled = false;

		}
	}
}
