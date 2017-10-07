using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyau_Tournant : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		rb.transform.Rotate (Vector3.forward, 90);
	}
}
