using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddyAI : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public Transform myTransform;
	public Transform target;
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
	}
}
