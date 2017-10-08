using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyau_Normal : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		Destroy (other.gameObject);
		}
	void OnTriggerStay2D(Collider2D other){
		Destroy (other.gameObject);
	}

}
