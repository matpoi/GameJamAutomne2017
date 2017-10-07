using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax; 
}

public class PlayerController : MonoBehaviour {

	public Boundary boundary;
	private float waitForFire;
	public float laserRate;
	public GameObject laser;
	public Transform laserSpawn; 

	private Rigidbody rb;

	public float speed; 
	// Use this for initialization
	void Update(){
		if (Input.GetButton ("Action") && Time.time > waitForFire) {
			waitForFire = Time.time + laserRate; 
			Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
		}	
	}

	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal"); 

		Vector2 movement = new Vector3 (move, 0.0f, 0.0f);
		rb.velocity = movement * speed; 

		rb.position = new Vector3 (
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax), 0.0f, 0.0f
		);
	}

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
}
