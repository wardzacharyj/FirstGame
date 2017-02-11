using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadetoBlack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Started");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Entered");
		Camera camM = GameObject.Find("MainCamera").GetComponent<Camera>();
		camM.enabled = false;
		AudioSource[] a = AudioListener.FindObjectsOfType<AudioSource> ();
		foreach (AudioSource audioS in a) {
			audioS.Stop ();
		}

		AudioSource z = GameObject.Find("Crash_Sound").GetComponent<AudioSource>();
		z.Play ();

	}
}
