using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {

	public float speed = 2.0f;
	public Boundary boundary;

	public GameObject coup;
	public Transform coupSpawn;
	public float punchRate;

	private float nextPunch;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		//PARTIE 1 : TIR
		if (Input.GetKeyDown("space") && Time.time > nextPunch){
			nextPunch = Time.time + punchRate;
			GameObject coups = Instantiate(coup, coupSpawn.position, coupSpawn.rotation);
			coups.transform.parent = gameObject.transform;
			//AudioSource audio = GetComponent<AudioSource>();
			//audio.Play();
		}
		/////////////////////////////////////
	}

	void FixedUpdate ()
	{

		//PARTIE 1 : MOUVEMENT////
		Vector3 direction = new Vector3(Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f);
		Vector3 newPos = transform.position + direction*speed;

		newPos.x = Mathf.Clamp(newPos.x, boundary.xMin, boundary.xMax);
		newPos.y = Mathf.Clamp(newPos.y, boundary.yMin, boundary.yMax);

		transform.position = newPos;
	}
}
