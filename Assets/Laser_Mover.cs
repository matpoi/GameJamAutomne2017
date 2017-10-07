using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Mover : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed;

	}

}