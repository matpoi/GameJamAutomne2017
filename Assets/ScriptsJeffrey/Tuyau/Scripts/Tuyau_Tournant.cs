﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyau_Tournant : MonoBehaviour {

	public RemanentData rD;
	private Rigidbody2D rb;
	private float degree; 
	public float speed; 

	private float waitForTurn;
	public float turnRate; 
	private bool touch = false;
	public bool droite; 
	private Quaternion ancienRotation;
	private float angleDepart;
	// Use this for initialization
	void Start () {
		rb = GetComponentInParent<Rigidbody2D> ();
	}  

	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		degree = rD.angle;
		if (droite == true) {
			degree += 90  ;
		} else {
			degree += -90 ;
		}
			
		rD.angle = degree;
		touch = true; 
		waitForTurn = Time.time + turnRate; 
	}
	// Update is called once per frame
	void Update () {
		if (touch) {
			rb.transform.rotation = Quaternion.Slerp (rb.transform.rotation, Quaternion.Euler (0, 0, degree), Time.deltaTime * speed);
		}  	 if (touch == true && Time.time > waitForTurn) {
			touch = false;
		}
	}
}
