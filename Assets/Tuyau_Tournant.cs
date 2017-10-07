using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyau_Tournant : MonoBehaviour {

	private Rigidbody2D rb;
	private float degree; 
	public float speed; 
	public bool droite; 
	// Use this for initialization
	void Start () {
		rb = GetComponentInParent<Rigidbody2D> ();

	}  

	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		if (droite == true) {
			degree += 90;
		} else {
			degree += -90;
		}
	}
	// Update is called once per frame
	void Update () {
			rb.transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, degree*2), Time.deltaTime*speed);
}
}
