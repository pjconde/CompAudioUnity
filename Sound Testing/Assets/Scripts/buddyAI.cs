using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddyAI : MonoBehaviour {

	public float speed;
	public Transform target;

	public AudioSource sound;
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
		if (Input.GetKeyDown(KeyCode.V)) {
			sound.Play();
		}
	}
}
