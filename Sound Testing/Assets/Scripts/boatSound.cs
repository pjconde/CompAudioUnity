using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatSound : MonoBehaviour {

	// Use this for initialization
	public AudioSource sound;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.B)) {
			sound.Play();
		}
	}
}
